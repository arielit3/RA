using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;
using RepromosRA.Data;
using RepromosRA.Models;

namespace RepromosRA.Repositories
{
    public class UsuarioRepository
    {
        public Usuario? GetByUsername(string username)
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            const string sql = @"
            SELECT Id, FullName, Rol, Usuario, PasswordHash, FechaRegistro
            FROM Usuarios
            WHERE Usuario = @u
            LIMIT 1;";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);

            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;

            return new Usuario
            {
                Id = r.GetInt32(0),
                FullName = r.GetString(1),
                Rol = r.GetString(2),
                Username = r.GetString(3),
                PasswordHash = r.GetString(4),
                FechaRegistro = DateTime.Parse(r.GetString(5))
            };
        }
    }
}
