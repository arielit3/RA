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
    public partial class fm_SClientes : Form
    {
        public fm_SClientes()
        {
            InitializeComponent();
        }

        private void fm_SClientes_Load(object sender, EventArgs e)
        {
            dgview_clientes.AutoGenerateColumns = false;
            //sin esta propiedad se generarian columnas automaticamente segun el valor que
            //se agrega al datasource
            dgview_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview_clientes.MultiSelect = false;
            dgview_clientes.ReadOnly = false;
            dgview_clientes.Columns.Clear();

            dgview_clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",//propiedad que mostrara
                HeaderText = "ID",//titulo
                Name = "id"//nombre interno para referencia a la columna
            });
            dgview_clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre"
            });
            dgview_clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Telefono",
                Name = "Telefono"
            });
            dgview_clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Direccion",
                Name = "Direccion"
            });

            CargarClientes(DatosGlobales.Clientes);
        }
        private void CargarClientes(List<Cliente> lista)
            //metodo para cargar los datos en el datagridview, recibe los datos de
            //la lista de clientes creando una instancia de esta misma almacenandolos en lista
        {
            var datos = lista.Select(c => new
            //con datos, creamos un objeto que obtiene los valores de la lista
            {
                c.id,
                //c funciona como un objeto temporal que obtiene los valores de la lista y asi llamamos a cada valor
                c.Nombre,
                c.Telefono,
                c.Direccion
            }).ToList();
            //cada objeto creado se almacena en una lista llamada datos

            dgview_clientes.DataSource = datos;
            //enviamos la lista datos al datagridview como su datasource para que asi cargue y ordene
            //tomando ya en base como referencia a las columnas creadas anteriormente
        }

        private void btn_registrarProv_Click(object sender, EventArgs e)
            //este es el btn para registrar CLIENTES
        {
            if (string.IsNullOrWhiteSpace(tbox_nombre.Text)||
                string.IsNullOrWhiteSpace(tbox_telefono.Text)||
                string.IsNullOrWhiteSpace(tbox_direccion.Text)) 
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            
            }

            //instancia a la clase cliente obteniendo las propiedades
            //de esta
            var nuevoCliente = new Cliente
            //nuevoCliente funciona como un objeto temporal para guardar los datos del nuevo cliente
            //esto funciona porque declaramos que nuevo cliente es igual a Cliente obteniendo asi
            //las propiedades base de cliente
            {
                //declaramos un valor por propiedad
                id = DatosGlobales.Clientes.Count > 0 ? DatosGlobales.Clientes.Max(c => c.id) + 1 : 1,
                Nombre = tbox_nombre.Text,
                Telefono = tbox_telefono.Text,
                Direccion = tbox_direccion.Text
            };

            DatosGlobales.Clientes.Add(nuevoCliente);
            CargarClientes(DatosGlobales.Clientes);

            MessageBox.Show("Cliente registrado exitosamente.");
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_borrarProv_Click(object sender, EventArgs e)
        {
            if (dgview_clientes.SelectedRows.Count > 0)
            {
                int clienteid = (int)dgview_clientes.SelectedRows[0].Cells["id"].Value;
                var clienteABorrar = DatosGlobales.Clientes.FirstOrDefault(c => c.id == clienteid);
                if (clienteABorrar != null)
                {
                    DatosGlobales.Clientes.Remove(clienteABorrar);
                    CargarClientes(DatosGlobales.Clientes);
                    MessageBox.Show("Cliente eliminado exitosamente.");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un cliente para borrar.");
            }
        }

        private void tbox_filtroId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbox_filtroId.Text, out int id))
            {
                var resultado = DatosGlobales.Clientes.Where(c => c.id == id).ToList();
                CargarClientes(resultado);
            }
            else
            {
                CargarClientes(DatosGlobales.Clientes);
            }
        }
    }
}
