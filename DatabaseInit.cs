using System;
using Microsoft.Data.Sqlite;
using RepromosRA.Data;

namespace RepromosRA
{
    public static class DatabaseInit
    {
        public static void EnsureCreated()
        {
            using var conn = SQLiteConnectionFactory.GetConnection();
            conn.Open();

            // Importante en SQLite para respetar FKs (opcional pero recomendado)
            using (var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", conn))
                pragma.ExecuteNonQuery();

            string sql = @"
            CREATE TABLE IF NOT EXISTS Usuarios (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                Rol TEXT NOT NULL,
                Usuario TEXT NOT NULL UNIQUE,
                PasswordHash TEXT NOT NULL,
                FechaRegistro TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Clientes (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre TEXT NOT NULL,
                Telefono TEXT,
                Email TEXT,
                Direccion TEXT,
                Activo INTEGER NOT NULL DEFAULT 1
            );

            CREATE TABLE IF NOT EXISTS Proveedores (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre TEXT NOT NULL,
                Telefono TEXT,
                Email TEXT,
                Direccion TEXT,              -- ✅ agregado para nuevas instalaciones
                Activo INTEGER NOT NULL DEFAULT 1
            );

            CREATE TABLE IF NOT EXISTS Paquetes (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                CodigoRastreo TEXT NOT NULL UNIQUE,
                ClienteId INTEGER NOT NULL,
                ProveedorId INTEGER NOT NULL,
                PesoKg REAL NOT NULL DEFAULT 0,
                Descripcion TEXT,
                Estado TEXT NOT NULL,
                FechaRecepcion TEXT NOT NULL,
                FechaEnvio TEXT NULL,

                FOREIGN KEY(ClienteId) REFERENCES Clientes(Id),
                FOREIGN KEY(ProveedorId) REFERENCES Proveedores(Id)
            );

            CREATE INDEX IF NOT EXISTS IX_Paquetes_CodigoRastreo ON Paquetes(CodigoRastreo);
            CREATE INDEX IF NOT EXISTS IX_Paquetes_ClienteId ON Paquetes(ClienteId);
            CREATE INDEX IF NOT EXISTS IX_Paquetes_ProveedorId ON Paquetes(ProveedorId);
            ";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            // ✅ Migraciones para DB ya creada antes (ALTER TABLE)
            ApplyMigrations(conn);
        }

        private static void ApplyMigrations(SqliteConnection conn)
        {
            // ✅ Este es tu error actual:
            AddColumnIfNotExists(conn, "Proveedores", "Direccion", "TEXT");

            // Recomendadas (por si en algún punto las usas en repos)
            AddColumnIfNotExists(conn, "Clientes", "Direccion", "TEXT");
            AddColumnIfNotExists(conn, "Clientes", "Activo", "INTEGER NOT NULL DEFAULT 1");
            AddColumnIfNotExists(conn, "Proveedores", "Activo", "INTEGER NOT NULL DEFAULT 1");
        }

        private static void AddColumnIfNotExists(SqliteConnection conn, string table, string column, string definition)
        {
            using var cmd = new SqliteCommand($"PRAGMA table_info({table});", conn);
            using var r = cmd.ExecuteReader();

            while (r.Read())
            {
                var colName = r.GetString(1);
                if (string.Equals(colName, column, StringComparison.OrdinalIgnoreCase))
                    return; // ✅ ya existe
            }

            using var alter = new SqliteCommand($"ALTER TABLE {table} ADD COLUMN {column} {definition};", conn);
            alter.ExecuteNonQuery();
        }
    }
}
