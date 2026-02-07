using Microsoft.Data.Sqlite;
using RepromosRA.Data;
using RepromosRA.Models;
using System.Collections.Generic;

namespace RepromosRA.Repositories
{
    public class ProveedorRepository
    {
        public List<Proveedor> GetAll()
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            SELECT Id, Nombre, Telefono, Email, Direccion, Activo
            FROM Proveedores
            WHERE Activo = 1
            ORDER BY Nombre;";

            using var cmd = new SqliteCommand(sql, conn);
            using var r = cmd.ExecuteReader();

            var list = new List<Proveedor>();
            while (r.Read())
            {
                list.Add(new Proveedor
                {
                    Id = r.GetInt32(0),
                    Nombre = r.GetString(1),
                    Telefono = r.IsDBNull(2) ? "" : r.GetString(2),
                    Email = r.IsDBNull(3) ? "" : r.GetString(3),
                    Direccion = r.IsDBNull(4) ? "" : r.GetString(4),
                    Activo = r.GetInt32(5) == 1
                });
            }
            return list;
        }

        public void Add(Proveedor p)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            INSERT INTO Proveedores (Nombre, Telefono, Email, Direccion, Activo)
            VALUES (@n, @t, @e, @d, 1);";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@n", p.Nombre);
            cmd.Parameters.AddWithValue("@t", p.Telefono);
            cmd.Parameters.AddWithValue("@e", p.Email);
            cmd.Parameters.AddWithValue("@d", p.Direccion);

            cmd.ExecuteNonQuery();
        }

        public void Update(Proveedor p)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            UPDATE Proveedores
            SET Nombre=@n, Telefono=@t, Email=@e, Direccion=@d
            WHERE Id=@id;";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@n", p.Nombre);
            cmd.Parameters.AddWithValue("@t", p.Telefono);
            cmd.Parameters.AddWithValue("@e", p.Email);
            cmd.Parameters.AddWithValue("@d", p.Direccion);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();
        }

        public void Desactivar(int id)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"UPDATE Proveedores SET Activo = 0 WHERE Id=@id;";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
