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
        }
    }
}