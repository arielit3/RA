using Microsoft.Data.Sqlite;
using ReprmosRA.Security;
using RepromosRA.Data;
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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            comboBxROL.Items.Clear();
            comboBxROL.Items.Add("Admin");
            comboBxROL.Items.Add("Operador");
            comboBxROL.SelectedIndex = 0;
        }

        private void txtBxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBxROL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            string fullName = txtBxFullName.Text.Trim();
            string rol = comboBxROL.Text.Trim();
            string user = txtBxUser.Text.Trim();
            string pass = txtBxPassword.Text;
            string confirm = txtBxConfirmPass.Text;

            // 1) Validaciones
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(rol) ||
                string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // 2) Hash de contraseña
            string hash = PasswordHasher.Hash(pass);

            // 3) Insert en SQLite
            try
            {
                using (var conn = SQLiteConnectionFactory.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            INSERT INTO Usuarios (FullName, Rol, Usuario, PasswordHash, FechaRegistro)
            VALUES (@full, @rol, @user, @hash, @fecha);";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@full", fullName);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("User registered successfully!");

                // Limpieza de campos (opcional)
                txtBxFullName.Clear();
                comboBxROL.SelectedIndex = -1;
                txtBxUser.Clear();
                txtBxPassword.Clear();
                txtBxConfirmPass.Clear();
            }
            catch (SqliteException ex)
            {
                if (ex.Message.ToLower().Contains("unique"))
                    MessageBox.Show("That username already exists.");
                else
                    MessageBox.Show("SQLite error: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
