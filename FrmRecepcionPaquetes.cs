using RepromosRA.Security;
using RepromosRA.Models;
using RepromosRA.Repositories;
using RepromosRA.Services;
using System;
using System.Windows.Forms;

namespace RepromosRA
{
    public partial class FrmRecepcionPaquetes : Form
    {
        private readonly ClienteRepository _clienteRepo;
        private readonly ProveedorRepository _proveedorRepo;
        private readonly PaqueteService _paqueteService;

        public FrmRecepcionPaquetes()
        {
            InitializeComponent();

            _clienteRepo = new ClienteRepository();
            _proveedorRepo = new ProveedorRepository();
            _paqueteService = new PaqueteService(new PaqueteRepository());
        }

        private void FrmRecepcionPaquetes_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";

            // El código ya NO se escribe: se genera al registrar
            txtBxCodigoRastreo.ReadOnly = true;
            txtBxCodigoRastreo.Text = "(Se generará automáticamente)";

            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                var clientes = _clienteRepo.GetAll();
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "Id";
                cmbCliente.SelectedIndex = clientes.Count > 0 ? 0 : -1;

                var proveedores = _proveedorRepo.GetAll();
                cmbProveedor.DataSource = proveedores;
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Id";
                cmbProveedor.SelectedIndex = proveedores.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Clientes/Proveedores: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ✅ Este es el botón real: btnRegisterUser.Click += btnRegisterUser_Click
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue == null || cmbProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona un cliente y un proveedor.");
                    return;
                }

                int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);
                int proveedorId = Convert.ToInt32(cmbProveedor.SelectedValue);

                if (!decimal.TryParse(txtBxPeso.Text.Trim(), out decimal peso) || peso < 0)
                {
                    MessageBox.Show("Peso inválido. Ejemplo: 1.25");
                    return;
                }

                string descripcion = txtDescripcion.Text.Trim();

                var paquete = new Paquete
                {
                    CodigoRastreo = null, // ✅ se genera en el service
                    ClienteId = clienteId,
                    ProveedorId = proveedorId,
                    PesoKg = peso,
                    Descripcion = descripcion
                };

                string codigoGenerado = _paqueteService.RegistrarRecepcion(paquete);

                txtBxCodigoRastreo.Text = codigoGenerado;

                MessageBox.Show($"Recepción registrada.\nCódigo de rastreo: {codigoGenerado}");

                // Limpieza de campos (deja el código mostrado)
                txtBxPeso.Clear();
                txtDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ---- Handlers enlazados en el Designer (los dejamos para no romper nada) ----
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtBxCodigoRastreo_TextChanged(object sender, EventArgs e) { }
        private void txtBxPeso_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void labelByUser_Click(object sender, EventArgs e) { }

        // ⚠️ En tu Designer existe: label6.Click += label6_Click;
        private void label6_Click(object sender, EventArgs e) { }

        private void btnAdministrarProveedores_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmProveedores())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            CargarCombos();
        }

        private void btnAdministrarClientes_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmClientes())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            CargarCombos();
        }
    }
}
