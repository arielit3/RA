using RepromosRA.Models;
using RepromosRA.Repositories;
using RepromosRA.Services;
using System;
using System.Windows.Forms;
using RepromosRA.Security;

namespace RepromosRA
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteService _service;
        private int _clienteId = 0;

        public FrmClientes()
        {
            InitializeComponent();
            _service = new ClienteService(new ClienteRepository());
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";

            // UI
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.AutoGenerateColumns = true;

            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _service.Listar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var c = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            _clienteId = c.Id;

            txtNombre.Text = c.Nombre;
            txtTelefono.Text = c.Telefono;
            txtEmail.Text = c.Email;
            txtDireccion.Text = c.Direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    return;
                }

                var c = new Cliente
                {
                    Id = _clienteId,
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                if (_clienteId == 0)
                    _service.Crear(c);
                else
                    _service.Editar(c);

                Limpiar();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clienteId == 0)
            {
                MessageBox.Show("Selecciona un cliente del listado.");
                return;
            }

            if (MessageBox.Show("¿Desactivar cliente?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Eliminar(_clienteId);
                Limpiar();
                CargarGrid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _clienteId = 0;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reutilizamos la misma lógica de selección
            dgvClientes_CellClick(sender, e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handlers que el designer tiene conectados (los dejamos aunque no hagan nada)
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtTelefono_TextChanged(object sender, EventArgs e) { }
        private void txtDireccion_TextChanged(object sender, EventArgs e) { }
    }
}
