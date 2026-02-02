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
    public partial class fm_SPaquetes_Envio : Form
    {
        public fm_SPaquetes_Envio()
        {
            InitializeComponent();
        }

        private void btn_registrarPaq_Click(object sender, EventArgs e)
        {
            if (cbox_cliente.SelectedItem == null || string.IsNullOrWhiteSpace(tbox_nombre.Text))
            {
                MessageBox.Show("Debes ingresar el nombre del paquete y seleccionar un cliente.");
                return;
            }

            var nuevoPaq = new Paquete
            {
                Id = DatosGlobales.Paquetes.Count > 0 ? DatosGlobales.Paquetes.Max(p => p.Id) + 1 : 1,
                Nombre = tbox_nombre.Text,
                Cliente = (Cliente)cbox_cliente.SelectedItem,
                Proveedor = null,
                Estado = cbox_estado.SelectedItem.ToString(),
                Fecha = dtime_fecha.Value
            };
            DatosGlobales.Paquetes.Add(nuevoPaq);
            MessageBox.Show("Paquete de envío registrado con éxito.");
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_SPaquetes_Envio_Load(object sender, EventArgs e)
        {
            cbox_cliente.DataSource = DatosGlobales.Clientes;
            cbox_cliente.DisplayMember = "Nombre";
            cbox_cliente.ValueMember = "Id";

            cbox_estado.Items.Clear();
            cbox_estado.Items.AddRange(new string[]
            {
                "En revision",
                "Enviado",
                "Entregado",
                "Rectificado"
            });
            cbox_estado.SelectedIndex = 0; //por defecto lo dejamos en enviado

            tbox_nombre.Text = string.Empty;
        }
    }
}
