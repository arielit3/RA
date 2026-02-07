using RepromosRA.Models;
using RepromosRA.Repositories;
using RepromosRA.Security;
using RepromosRA.Services;
using System;
using System.Windows.Forms;

namespace RepromosRA
{
    public partial class FrmProveedores : Form
    {
        private readonly ProveedorService _service;
        private int _proveedorId = 0;

        public FrmProveedores()
        {
            InitializeComponent();
            _service = new ProveedorService(new ProveedorRepository());
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            labelByUser.Text = Session.CurrentUser?.FullName ?? "";

            dgvProveedores.ReadOnly = true;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.MultiSelect = false;
            dgvProveedores.AutoGenerateColumns = true;

            CargarGrid();
            Limpiar();
        }

        private void CargarGrid()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = _service.Listar();
        }

        // ✅ IMPORTANTE: Enlaza este evento en el diseñador: dgvProveedores.CellClick
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var p = (Proveedor)dgvProveedores.Rows[e.RowIndex].DataBoundItem;
            _proveedorId = p.Id;

            txtNombre.Text = p.Nombre;
            txtTelefono.Text = p.Telefono;
            txtEmail.Text = p.Email;
            txtDireccion.Text = p.Direccion;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            try
            {
                var p = new Proveedor
                {
                    Id = _proveedorId,
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                if (_proveedorId == 0)
                    _service.Crear(p);
                else
                    _service.Editar(p);

                CargarGrid();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_proveedorId == 0)
            {
                MessageBox.Show("Selecciona un proveedor primero.");
                return;
            }

            if (MessageBox.Show("¿Desactivar proveedor?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Eliminar(_proveedorId);
                CargarGrid();
                Limpiar();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            _proveedorId = 0;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
        }

        // Handlers enlazados en Designer (vacíos, para no romper)
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtTelefono_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtDireccion_TextChanged(object sender, EventArgs e) { }
        private void labelByUser_Click(object sender, EventArgs e) { }
    }
}
