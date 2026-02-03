using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA.Models
{
    public class Paquete
    {
        public int Id { get; set; }
        public string CodigoRastreo { get; set; } // único
        public int ProveedorId { get; set; }
        public int ClienteId { get; set; }

        public decimal PesoKg { get; set; }
        public string Descripcion { get; set; }

        public string Estado { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime? FechaEnvio { get; set; }
    }

}
