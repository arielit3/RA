using RepromosRA.Repositories;
using RepromosRA.Services;

namespace RepromosRA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // oculta contraseña
            TxtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = TxtUser.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Enter user and password.");
                return;
            }

            try
            {
                var auth = new AuthService(new UsuarioRepository());
                var loggedUser = auth.Login(user, pass);

                // Abrir menú principal y pasar el usuario
                using (var main = new FrmMain(loggedUser))
                {
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }

                // Limpieza opcional
                TxtUser.Clear();
                txtPassword.Clear();
                TxtUser.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new RegisterUser())
            {
                this.Hide();              // oculta login mientras registras
                frm.ShowDialog();         // modal: no permite volver sin cerrar registro
                this.Show();              // regresa login cuando se cierra el registro
            }
        }
    }
}
