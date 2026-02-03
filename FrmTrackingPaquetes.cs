using RepromosRA.Security;
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
    public partial class FrmTrackingPaquetes : Form
    {
        public FrmTrackingPaquetes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMarcarEntregado_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: aquí irá la búsqueda por código de rastreo
        }

        private void btnRegistrarEnvio_Click(object sender, EventArgs e)
        {
            // TODO: aquí irá registrar envío (cambiar estado a EnTransito)
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblClienteID_Click(object sender, EventArgs e)
        {

        }

        private void lblProveedorID_Click(object sender, EventArgs e)
        {

        }

        private void lblFechas_Click(object sender, EventArgs e)
        {

        }

        private void labelByUser_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrackingPaquetes_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";
        }
    }
}
