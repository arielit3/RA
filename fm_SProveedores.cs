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
    public partial class fm_SProveedores : Form
    {
        public fm_SProveedores()
        {
            InitializeComponent();
        }

        private void fm_SProveedores_Load(object sender, EventArgs e)
        {
            dgview_proveedores.AutoGenerateColumns = false;
            dgview_proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview_proveedores.MultiSelect = false;
            dgview_proveedores.ReadOnly = false; // permitir edicion directa
            dgview_proveedores.Columns.Clear();

            // Agregar columnas al DataGridView
            dgview_proveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID",
                Name = "id"
            });

            // Columna Nombre
            dgview_proveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre"
            });

            // Columna Contacto
            dgview_proveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contacto",
                HeaderText = "Contacto",
                Name = "Contacto"
            });

            // Columna Teléfono
            dgview_proveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Name = "Telefono"
            });

            dgview_proveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Direccion",
                Name = "Direccion"
            });

            CargarProveedores(DatosGlobales.Proveedores);

        }
        private void CargarProveedores(List<Proveedor> lista)
        {
            var datos = lista.Select(p => new
            {
                p.id,
                p.Nombre,
                p.Contacto,
                p.Telefono,
                p.Direccion
            }).ToList();

            dgview_proveedores.DataSource = datos;
        }

        private void btn_registrarProv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbox_nombre.Text) ||
        string.IsNullOrWhiteSpace(tbox_contacto.Text) ||
        string.IsNullOrWhiteSpace(tbox_telefono.Text) ||
        string.IsNullOrWhiteSpace(tbox_direccion.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            var nuevoProveedor = new Proveedor
            {
                id = DatosGlobales.Proveedores.Count > 0 ? DatosGlobales.Proveedores.Max(p => p.id) + 1 : 1,
                Nombre = tbox_nombre.Text,
                Contacto = tbox_contacto.Text,
                Telefono = tbox_telefono.Text,
                Direccion = tbox_direccion.Text
            };

            DatosGlobales.Proveedores.Add(nuevoProveedor);
            CargarProveedores(DatosGlobales.Proveedores);

            MessageBox.Show("Proveedor registrado correctamente.");

        }

        private void btn_borrarProv_Click(object sender, EventArgs e)
        {
            if (dgview_proveedores.SelectedRows.Count > 0)
            {
                int proveedorId = (int)dgview_proveedores.SelectedRows[0].Cells["id"].Value;
                var proveedor = DatosGlobales.Proveedores.FirstOrDefault(p => p.id == proveedorId);

                if (proveedor != null)
                {
                    DatosGlobales.Proveedores.Remove(proveedor);
                    CargarProveedores(DatosGlobales.Proveedores);
                    MessageBox.Show("Proveedor eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para borrar.");
            }

        }

        private void tbox_filtroId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbox_filtroId.Text, out int id))
            {
                var resultado = DatosGlobales.Proveedores.Where(p => p.id == id).ToList();
                CargarProveedores(resultado);
            }
            else
            {
                CargarProveedores(DatosGlobales.Proveedores);
            }

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
