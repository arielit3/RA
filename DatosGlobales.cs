using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA
{
    public static class DatosGlobales
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
            new Proveedor { id = 1, Nombre = "DHL", Contacto = "Carlos", Telefono = "123-456-789"},
            new Proveedor { id = 2, Nombre = "FedEx", Contacto = "Ana", Telefono = "987-654-321"},
        };

        public static List<Paquete> Paquetes = new List<Paquete>();
    }
}
