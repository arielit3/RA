using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepromosRA
{
    public partial class fm_SPaquetes : Form
    {
        public fm_SPaquetes()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar al inicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Con esto obtenemos un resultado de si el usuario desea regresar al inicio o no solicitando confirmacion
            if (resultado == DialogResult.Yes)
            //el dialogresult funciona como una variable bool, donde yes es true y no es false, luego al seleccionar una opcion ya por esto si es yes 
            {
                this.Close();//cerramos esta ventana y regresamos al forminiciial
            }

        }

        private void btn_fmRecepcionPaq_Click(object sender, EventArgs e)
        {
            fm_SPaquetes_Recepcion formularioRecepcionPaq = new fm_SPaquetes_Recepcion();
            formularioRecepcionPaq.ShowDialog();
        }

        private void btn_fmEnvioPaq_Click(object sender, EventArgs e)
        {

        }

        private void btn_fmPaquetesGeneral_Click(object sender, EventArgs e)
        {
            fm_SPaquetes_General formularioPaquetesGeneral = new fm_SPaquetes_General();
            formularioPaquetesGeneral.ShowDialog();
        }
    }
}
