using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepromosRA.Data;

namespace RepromosRA
{
    public static class DatabaseInit
    {
        public static void EnsureCreated()
        {
            using (var conn = SQLiteConnectionFactory.GetConnection())
            {
                conn.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Rol TEXT NOT NULL,
                    Usuario TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    FechaRegistro TEXT NOT NULL
                );";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}