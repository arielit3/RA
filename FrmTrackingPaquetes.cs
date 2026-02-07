using RepromosRA.Repositories;
using RepromosRA.Security;
using RepromosRA.Services;
using System;
using System.Windows.Forms;

namespace RepromosRA
{
    public partial class FrmTrackingPaquetes : Form
    {
        private readonly PaqueteService _service;

        public FrmTrackingPaquetes()
        {
            InitializeComponent();
            _service = new PaqueteService(new PaqueteRepository());
        }

        private void FrmTrackingPaquetes_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";

            ConfigurarGrid();
            CargarGrid();
            LimpiarDetalle();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ----------------------------
        // GRID
        // ----------------------------
        private void ConfigurarGrid()
        {
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.MultiSelect = false;
            dgvPaquetes.AutoGenerateColumns = true;
        }

        private void CargarGrid()
        {
            try
            {
                dgvPaquetes.DataSource = null;
                dgvPaquetes.DataSource = _service.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paquetes: " + ex.Message);
            }
        }

        private void btnRefrescarDataGridView_Click(object sender, EventArgs e)
        {
            CargarGrid();
            LimpiarDetalle();
            txtBxCodigoRastreo.Clear();
        }

        private void dgvPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando el usuario hace click en una celda, tomamos el código
            if (e.RowIndex < 0) return;

            var row = dgvPaquetes.Rows[e.RowIndex];
            if (row?.Cells["CodigoRastreo"]?.Value == null) return;

            txtBxCodigoRastreo.Text = row.Cells["CodigoRastreo"].Value.ToString();

            // Opcional: hacer búsqueda automática al seleccionar
            btnBuscar_Click(sender, e);
        }

        // ----------------------------
        // BOTONES
        // ----------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBxCodigoRastreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingresa un código de rastreo o selecciona un paquete en la tabla.");
                return;
            }

            try
            {
                var p = _service.Consultar(codigo);

                lblEstado.Text = p.Estado;
                lblClienteID.Text = p.ClienteId.ToString();
                lblProveedorID.Text = p.ProveedorId.ToString();

                string envio = p.FechaEnvio.HasValue
                    ? p.FechaEnvio.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    : "N/A";

                lblFechas.Text = $"Recepción: {p.FechaRecepcion:yyyy-MM-dd HH:mm:ss} | Envío: {envio}";

                // habilitar botones según estado
                btnRegistrarEnvio.Enabled = (p.Estado == "Recibido");
                btnMarcarEntregado.Enabled = (p.Estado == "EnTransito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarDetalle();
            }
        }

        private void btnRegistrarEnvio_Click(object sender, EventArgs e)
        {
            string codigo = txtBxCodigoRastreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Selecciona un paquete o escribe un código de rastreo.");
                return;
            }

            try
            {
                _service.RegistrarEnvio(codigo);
                MessageBox.Show("Envío registrado (Estado: EnTransito).");

                CargarGrid();
                btnBuscar_Click(sender, e); // refresca el panel de detalle
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMarcarEntregado_Click(object sender, EventArgs e)
        {
            string codigo = txtBxCodigoRastreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Selecciona un paquete o escribe un código de rastreo.");
                return;
            }

            try
            {
                _service.MarcarEntregado(codigo);
                MessageBox.Show("Paquete marcado como Entregado.");

                CargarGrid();
                btnBuscar_Click(sender, e); // refresca el panel de detalle
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ----------------------------
        // UTILIDADES UI
        // ----------------------------
        private void LimpiarDetalle()
        {
            lblEstado.Text = "-";
            lblClienteID.Text = "-";
            lblProveedorID.Text = "-";
            lblFechas.Text = "-";

            btnRegistrarEnvio.Enabled = false;
            btnMarcarEntregado.Enabled = false;
        }

        // Estos handlers están enlazados en el Designer: se quedan vacíos si no los usas
        private void lblEstado_Click(object sender, EventArgs e) { }
        private void lblClienteID_Click(object sender, EventArgs e) { }
        private void lblProveedorID_Click(object sender, EventArgs e) { }
        private void lblFechas_Click(object sender, EventArgs e) { }
        private void labelByUser_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
