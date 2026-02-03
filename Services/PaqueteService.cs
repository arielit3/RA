using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void RegistrarRecepcion(Paquete p)
        {
            if (string.IsNullOrWhiteSpace(p.CodigoRastreo))
                throw new ArgumentException("CodigoRastreo es obligatorio.");

            if (p.ClienteId <= 0 || p.ProveedorId <= 0)
                throw new ArgumentException("Cliente y Proveedor son obligatorios.");

            p.Estado = "Recibido";
            p.FechaRecepcion = DateTime.Now;
            p.FechaEnvio = null;

            try
            {
                _repo.Add(p);
            }
            catch (SqliteException ex) when (ex.Message.ToLower().Contains("unique"))
            {
                throw new InvalidOperationException("El código de rastreo ya existe.");
            }
        }

        public void RegistrarEnvio(string codigoRastreo)
        {
            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");

            // Regla: Solo puedes enviar si está Recibido
            if (p.Estado != "Recibido")
                throw new InvalidOperationException($"No puedes enviar un paquete en estado '{p.Estado}'.");

            _repo.UpdateEstado(p.Id, "EnTransito", DateTime.Now);
        }

        public void MarcarEntregado(string codigoRastreo)
        {
            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");

            // Regla: Solo puedes entregar si está EnTransito
            if (p.Estado != "EnTransito")
                throw new InvalidOperationException($"No puedes marcar entregado un paquete en estado '{p.Estado}'.");

            _repo.UpdateEstado(p.Id, "Entregado");
        }

        public Paquete Consultar(string codigoRastreo)
        {
            var p = _repo.GetByCodigo(codigoRastreo);
            if (p == null) throw new InvalidOperationException("Paquete no encontrado.");
            return p;
        }
    }
}

