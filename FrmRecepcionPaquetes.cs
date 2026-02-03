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
    public partial class FrmRecepcionPaquetes : Form
    {
        public FrmRecepcionPaquetes()
        {
            InitializeComponent();
        }

        private void FrmRecepcionPaquetes_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBxCodigoRastreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {

        }

        private void labelByUser_Click(object sender, EventArgs e)
        {

        }
    }
}
