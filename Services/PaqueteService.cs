using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RepromosRA.Models;
using RepromosRA.Repositories;

namespace RepromosRA.Services
{
    public class PaqueteService
    {
        private readonly PaqueteRepository _repo;

        public PaqueteService(PaqueteRepository repo)
        {
            _repo = repo;
        }

        // ✅ Ahora genera el código automáticamente y lo regresa
        public string RegistrarRecepcion(Paquete p)
        {
            if (p.ClienteId <= 0 || p.ProveedorId <= 0)
                throw new ArgumentException("Cliente y Proveedor son obligatorios.");

            p.Estado = "Recibido";
            p.FechaRecepcion = DateTime.Now;
            p.FechaEnvio = null;

            // ✅ Si viene vacío, lo generamos automáticamente
            if (string.IsNullOrWhiteSpace(p.CodigoRastreo))
                p.CodigoRastreo = GenerarCodigoRastreo();

            // Por si ocurre una colisión (muy raro), reintenta generando otro
            for (int intento = 1; intento <= 3; intento++)
            {
                try
                {
                    _repo.Add(p);
                    return p.CodigoRastreo;
                }
                catch (SqliteException ex) when (ex.Message.ToLower().Contains("unique"))
                {
                    if (intento == 3)
                        throw new InvalidOperationException("No se pudo generar un código único de rastreo. Intenta de nuevo.");

                    p.CodigoRastreo = GenerarCodigoRastreo();
                }
            }

            // No debería llegar aquí
            throw new InvalidOperationException("Error inesperado al registrar la recepción.");
        }

        private string GenerarCodigoRastreo()
        {
            // AR-YYYYMMDD-XXXXXXXX
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string rand = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            return $"AR-{fecha}-{rand}";
        }

        public void RegistrarEnvio(string codigoRastreo)
        {
            if (string.IsNullOrWhiteSpace(codigoRastreo))
                throw new ArgumentException("Código de rastreo obligatorio.");

            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");

            // Regla: Solo puedes enviar si está Recibido
            if (p.Estado != "Recibido")
                throw new InvalidOperationException($"No puedes enviar un paquete en estado '{p.Estado}'.");

            _repo.UpdateEstado(p.Id, "EnTransito", DateTime.Now);
        }

        public void MarcarEntregado(string codigoRastreo)
        {
            if (string.IsNullOrWhiteSpace(codigoRastreo))
                throw new ArgumentException("Código de rastreo obligatorio.");

            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");

            // Regla: Solo puedes entregar si está EnTransito
            if (p.Estado != "EnTransito")
                throw new InvalidOperationException($"No puedes marcar entregado un paquete en estado '{p.Estado}'.");

            _repo.UpdateEstado(p.Id, "Entregado");
        }

        public Paquete Consultar(string codigoRastreo)
        {
            if (string.IsNullOrWhiteSpace(codigoRastreo))
                throw new ArgumentException("Código de rastreo obligatorio.");

            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");
            return p;
        }

        // ✅ Para llenar DataGridView en Tracking
        public List<Paquete> ListarTodos()
        {
            return _repo.GetAll();
        }
    }
}
