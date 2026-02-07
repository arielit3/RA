using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using RepromosRA.Data;
using RepromosRA.Models;

namespace RepromosRA.Repositories
{
    public class PaqueteRepository
    {
        public void Add(Paquete p)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            INSERT INTO Paquetes
            (CodigoRastreo, ClienteId, ProveedorId, PesoKg, Descripcion, Estado, FechaRecepcion, FechaEnvio)
            VALUES
            (@cod, @cli, @prov, @peso, @desc, @estado, @frec, @fenv);";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", p.CodigoRastreo);
            cmd.Parameters.AddWithValue("@cli", p.ClienteId);
            cmd.Parameters.AddWithValue("@prov", p.ProveedorId);
            cmd.Parameters.AddWithValue("@peso", (double)p.PesoKg);
            cmd.Parameters.AddWithValue("@desc", (object?)p.Descripcion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@estado", p.Estado);
            cmd.Parameters.AddWithValue("@frec", p.FechaRecepcion.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fenv", p.FechaEnvio.HasValue
                ? p.FechaEnvio.Value.ToString("yyyy-MM-dd HH:mm:ss")
                : (object)DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public Paquete? GetByCodigo(string codigoRastreo)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            SELECT Id, CodigoRastreo, ClienteId, ProveedorId, PesoKg, Descripcion, Estado, FechaRecepcion, FechaEnvio
            FROM Paquetes
            WHERE CodigoRastreo = @cod
            LIMIT 1;";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", codigoRastreo);

            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;

            return new Paquete
            {
                Id = r.GetInt32(0),
                CodigoRastreo = r.GetString(1),
                ClienteId = r.GetInt32(2),
                ProveedorId = r.GetInt32(3),
                PesoKg = (decimal)r.GetDouble(4),
                Descripcion = r.IsDBNull(5) ? "" : r.GetString(5),
                Estado = r.GetString(6),
                FechaRecepcion = DateTime.Parse(r.GetString(7)),
                FechaEnvio = r.IsDBNull(8) ? (DateTime?)null : DateTime.Parse(r.GetString(8))
            };
        }

        // ✅ NUEVO: listar todos (para DataGridView)
        public List<Paquete> GetAll()
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            SELECT Id, CodigoRastreo, ClienteId, ProveedorId, PesoKg, Descripcion, Estado, FechaRecepcion, FechaEnvio
            FROM Paquetes
            ORDER BY Id DESC;";

            using var cmd = new SqliteCommand(sql, conn);
            using var r = cmd.ExecuteReader();

            var list = new List<Paquete>();
            while (r.Read())
            {
                list.Add(new Paquete
                {
                    Id = r.GetInt32(0),
                    CodigoRastreo = r.GetString(1),
                    ClienteId = r.GetInt32(2),
                    ProveedorId = r.GetInt32(3),
                    PesoKg = (decimal)r.GetDouble(4),
                    Descripcion = r.IsDBNull(5) ? "" : r.GetString(5),
                    Estado = r.GetString(6),
                    FechaRecepcion = DateTime.Parse(r.GetString(7)),
                    FechaEnvio = r.IsDBNull(8) ? (DateTime?)null : DateTime.Parse(r.GetString(8))
                });
            }

            return list;
        }

        public void UpdateEstado(int paqueteId, string nuevoEstado, DateTime? fechaEnvio = null)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            UPDATE Paquetes
            SET Estado = @estado,
                FechaEnvio = CASE WHEN @fenv IS NULL THEN FechaEnvio ELSE @fenv END
            WHERE Id = @id;";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@estado", nuevoEstado);
            cmd.Parameters.AddWithValue("@fenv", fechaEnvio.HasValue
                ? fechaEnvio.Value.ToString("yyyy-MM-dd HH:mm:ss")
                : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@id", paqueteId);

            cmd.ExecuteNonQuery();
        }
    }
}
