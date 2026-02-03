using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Rol { get; set; }          // Admin / Operador
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
