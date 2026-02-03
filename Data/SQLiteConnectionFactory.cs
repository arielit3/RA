using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;


namespace RepromosRA.Data
{
    public static class SQLiteConnectionFactory
    {
        private static string DbPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppData", "database.db");

        private static string ConnectionString =>
            $"Data Source={DbPath}";

        public static SqliteConnection GetConnection()
        {
            var folder = Path.GetDirectoryName(DbPath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return new SqliteConnection(ConnectionString);
        }
    }
}
