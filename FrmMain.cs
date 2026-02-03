using RepromosRA.Models;
using RepromosRA.Repositories;
using RepromosRA.Services;
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
    public partial class FrmMain : Form
    {
        private readonly Usuario _user;

        public FrmMain(Usuario user)
        {
            InitializeComponent();
            _user = user;
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Cerrar sesión y volver al Login
            var auth = new AuthService(new UsuarioRepository());
            auth.Logout();

            this.Close(); // regresa al Login porque Login lo abrió con ShowDialog()
        }

        private void btnTrackingPaquetes_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmTrackingPaquetes())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnRecepcionPaquetes_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRecepcionPaquetes())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void labelByUser_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Mostrar usuario en labelByUser
            labelByUser.Text = _user.FullName; // o _user.Username si prefieres
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
