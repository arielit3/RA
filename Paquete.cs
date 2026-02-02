using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepromosRA
{
    public class Paquete
    {
        public int id {  get; set; }
        public string Nombre { get; set; }//nombre de el paquete
        public Cliente? Cliente {  get; set; }//cliente relacionado con el paquete, puede ser null cuando es recibido
        //pero no enviado jaja
        public Proveedor? Proveedor {  get; set; }//proveedor relacionado con el paquete, puede ser null en caso de
        //donde el paquete es comprado
        public string Estado { get; set; }//estado de el paquete
        public DateTime Fecha { get; set; }//fecha de recibido o vendido de el paquete
    }
}
