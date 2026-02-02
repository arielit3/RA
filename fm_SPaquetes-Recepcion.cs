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
    public partial class fm_SPaquetes_Recepcion : Form
    {
        public fm_SPaquetes_Recepcion()
        {
            InitializeComponent();
        }

        private void fm_SPaquetes_Recepcion_Load(object sender, EventArgs e)
        {
            //Cargamos los proveedores
            cbox_proveedor.DataSource = DatosGlobales.Proveedores;
            cbox_proveedor.DisplayMember = "Nombre";
            cbox_proveedor.ValueMember = "Id";

            //cargamos los estados disponibles
            cbox_estado.Items.Add("En espera"); //el paquete esta en espera de recibirse
            cbox_estado.Items.Add("Recibido"); //el paquete ya fue recibido
            cbox_estado.Items.Add("Regresado"); //el paquete fue regresado
            cbox_estado.Items.Add("Rectificado"); //rectificado, osea que fue regresado
            cbox_estado.SelectedIndex = 1; //por defecto lo dejamos en recibido

            dtime_fecha.Value = DateTime.Now; //por defecto la fecha es la actual
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_registrarPaq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbox_nombre.Text) || cbox_proveedor.SelectedItem == null)
                //validamos que se haya ingresado un nombre y seleccionado un proveedor
            {
                MessageBox.Show("Debes ingresar el nombre del paquete y seleccionar un proveedor.");
                //si no se ingresa le decimos que debe de hacerlo
                return;
            }

            Paquete nuevo_paq = new Paquete
            //creamos la estructura para un nuevo paquete
            {
                id = DatosGlobales.Paquetes.Count+1,
                Nombre = tbox_nombre.Text,
                Cliente = null,
                Proveedor = (Proveedor)cbox_proveedor.SelectedItem,
                Estado = cbox_estado.SelectedItem.ToString(),
                Fecha = dtime_fecha.Value
                //llenamos los campos
            };

            DatosGlobales.Paquetes.Add(nuevo_paq);
            //creamos el nuevo paquete y lo agregamos a la lista global de paquetes


            MessageBox.Show("Paquete registrado exitosamente.");
            //Limpiamos los campos despues de registrar
            tbox_nombre.Clear();
            cbox_proveedor.SelectedItem = -1;
            cbox_estado.SelectedIndex = 1; //dejamos el estado en recibido por defecto
            dtime_fecha.Value = DateTime.Now;

        }
    }
}
