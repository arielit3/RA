using Microsoft.Data.Sqlite;
using RepromosRA.Data;
using RepromosRA.Models;
using System.Collections.Generic;

namespace RepromosRA.Repositories
{
    public class ClienteRepository
    {
        public List<Cliente> GetAll()
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            SELECT Id, Nombre, Telefono, Email, Direccion, Activo
            FROM Clientes
            WHERE Activo = 1
            ORDER BY Nombre;";

            using var cmd = new SqliteCommand(sql, conn);
            using var r = cmd.ExecuteReader();

            var list = new List<Cliente>();
            while (r.Read())
            {
                list.Add(new Cliente
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

        public void Add(Cliente c)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            INSERT INTO Clientes (Nombre, Telefono, Email, Direccion, Activo)
            VALUES (@n, @t, @e, @d, 1);";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@n", c.Nombre);
            cmd.Parameters.AddWithValue("@t", c.Telefono);
            cmd.Parameters.AddWithValue("@e", c.Email);
            cmd.Parameters.AddWithValue("@d", c.Direccion);

            cmd.ExecuteNonQuery();
        }

        public void Update(Cliente c)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            UPDATE Clientes
            SET Nombre=@n, Telefono=@t, Email=@e, Direccion=@d
            WHERE Id=@id;";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@n", c.Nombre);
            cmd.Parameters.AddWithValue("@t", c.Telefono);
            cmd.Parameters.AddWithValue("@e", c.Email);
            cmd.Parameters.AddWithValue("@d", c.Direccion);
            cmd.Parameters.AddWithValue("@id", c.Id);

            cmd.ExecuteNonQuery();
        }

        // 🔒 Borrado lógico
        public void Desactivar(int id)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"UPDATE Clientes SET Activo = 0 WHERE Id=@id;";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
