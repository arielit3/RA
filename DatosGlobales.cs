using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA
{
    public static class DatosGlobales
        //la clase de datos globales se usa para las listas que almacenan los datos de clientes, proveedores y paquetes
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        //creamos una lista para almacenar los clientes cada uno con sus datos
        {
            new Cliente { id = 1, Nombre = "Juana", Telefono = "123-456-789", Direccion="Av. Anapra"},
            new Cliente { id = 2, Nombre = "Carlos", Telefono = "987-654-321", Direccion="Riveras 9"},
            //creamos dos clientes base para pruebas
        };
        public static List<Proveedor> Proveedores = new List<Proveedor>()
        {
            new Proveedor { id = 1, Nombre = "DHL", Contacto = "Carlos", Telefono = "123-456-789", Direccion = "Las Torres"},
            new Proveedor { id = 2, Nombre = "FedEx", Contacto = "Ana", Telefono = "987-654-321", Direccion = "El paso TX"},
        };

        public static List<Paquete> Paquetes = new List<Paquete> 
        {
            //creamos paquetes para las pruebas
            new Paquete 
            { 
                Id = 1,
                Nombre = "ps15",
                Cliente = null,
                Proveedor = Proveedores[0],
                Estado = "Recibido",
                Fecha = DateTime.Now.AddDays(-2)
            },
            new Paquete 
            { 
                Id = 2,
                Nombre = "Documentos legales",
                Cliente = Clientes[1],
                Proveedor = null,
                Estado = "Rectificado",
                Fecha = DateTime.Now.AddDays(-1)
            },
            new Paquete 
            { 
                Id = 3,
                Nombre = "Laptop",
                Cliente = Clientes[0],
                Proveedor = Proveedores[1],
                Estado = "En revision",
                Fecha = DateTime.Now
            }
        };
    }
}
