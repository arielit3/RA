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
    public partial class fm_SPaquetes_General : Form
    {
        public fm_SPaquetes_General()
        {
            InitializeComponent();
        }

        private void fm_SPaquetes_General_Load(object sender, EventArgs e)
        {//al cargar el formulario

            dgview_paquetes.AutoGenerateColumns = false; //establecemos que no genere columnas por automatico
            dgview_paquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //selecciona la fila completa
            dgview_paquetes.MultiSelect = false; //tambien establecemos que solo se pueda seleccionar una fila a la vez
            dgview_paquetes.Columns.Clear(); //limpiamos las columnas por si acaso
            dgview_paquetes.EditMode = DataGridViewEditMode.EditOnEnter;
            dgview_paquetes.ReadOnly = false; // el grid no debe estar solo lectura

            //creamos las columnas de la tabla
            dgview_paquetes.Columns.Add(new DataGridViewTextBoxColumn
            {
                //columna de id
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id"
                //en caso de querer acceder por medio de buscar exactamente un valor de columna, debe de
                //darle nombre a cada columna
            });

            // Columna Nombre
            dgview_paquetes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre del Paquete"
            });

            // Columna Cliente
            dgview_paquetes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteNombre",
                HeaderText = "Cliente"
            });

            // Columna Proveedor
            dgview_paquetes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProveedorNombre",
                HeaderText = "Proveedor"
            });


            var estadoColumn = new DataGridViewComboBoxColumn
            {
                /* //esta es la columna de estado pero
                 DataPropertyName = "Estado",
                 HeaderText = "Estado",
                 //en esta establecemos opciones para edicion para que sea de seleccion y no de escribir
                 DataSource = new string[] { "En revision", "Recibido", "Rectificado" , "Enviado"}
                 //un arreglo basico para mostrar las opciones
                 */

                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Name = "Estado", // importante para acceder luego
                ValueType = typeof(string), // asegura que los valores son string
                DataSource = new string[] { "En revision", "Recibido", "Regresado", "Rectificado", "Enviado" },
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton // muestra el botón desplegable

            };
            dgview_paquetes.Columns.Add(estadoColumn);
            // Agregamos el evento para manejar cambios en el estado

            // Columna Fecha
            dgview_paquetes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha"
            });

            //Llamamos a un metodo para cargar los paquetes desde el inicio
            CargarPaquetes(DatosGlobales.Paquetes);


        }

        private void CargarPaquetes(List<Paquete> lista)
        {
            //creamos una proyeccion para mostrar los datos en el datagridview
            var datos = lista.Select(p => new
            {
                p.Id,
                p.Nombre,
                ClienteNombre = p.Cliente?.Nombre ?? "N/A",
                ProveedorNombre = p.Proveedor?.Nombre ?? "N/A",
                p.Estado,
                p.Fecha
            }).ToList();
            //convertimos cada objeto Paquete en un objeto anonimo con las propiedades necesarias
            //para asi mandarlas a el datagridview

            dgview_paquetes.DataSource = datos;
            //mandamos los datos de cada uno a el datagridview hasta finalizar
        }

        private void tbox_filtroID_TextChanged(object sender, EventArgs e)
        {
            //filtro por id
            if (int.TryParse(tbox_filtroID.Text, out int id))
            //si el valor ingresado en el tbox es numerico, se convierte y se pasa a id
            {
                var resultado = DatosGlobales.Paquetes.Where(p => p.Id == id).ToList();
                //con esto creamos resultado que es una lista de paquetes que cumplen con la condicion que este
                //segun el id escrito
                CargarPaquetes(resultado);
                //usamos el metodo de cargar paquetes para enviar que solo muestre los que cumplen la condicion
            }

        }

        private void btn_filtroRecibidos_Click(object sender, EventArgs e)
        {
            //un boton que funciona como filtro directo de todos los paquetes que esten con estado de recibidos
            var resultado = DatosGlobales.Paquetes.Where(p => p.Cliente == null).ToList();
            //creamos resultado que es una lista de paquetes que cumplen con la condicion que esten recibidos
            CargarPaquetes(resultado);
            //llamamos a el metodo de cargar paquetes para mostrar solo los paquetes con estado de recibidos
        }

        private void btn_filtroTodos_Click(object sender, EventArgs e)
        {
            var resultado = DatosGlobales.Paquetes;
            CargarPaquetes(resultado);
            //aqui mostramos todos los paquetes sin importar nada
        }

        private void btn_filtroEnviados_Click(object sender, EventArgs e)
        {
            var resultado = DatosGlobales.Paquetes.Where(p => p.Proveedor == null).ToList();
            CargarPaquetes(resultado);
        }

        private void btn_filtroRectificados_Click(object sender, EventArgs e)
        {
            var resultado = DatosGlobales.Paquetes.Where(p => p.Estado == "Rectificado").ToList();
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgview_paquetes.Rows)
            {
                int paqueteId = (int)row.Cells["Id"].Value;
                var paquete = DatosGlobales.Paquetes.FirstOrDefault(p => p.Id == paqueteId);
                //con paquete se obtiene el paquete correspondiente a la fila actual
                if (paquete != null)
                //si el paquete no es nulo, se actualiza su estado con el valor de la celda "Estado"
                {
                    //
                    paquete.Estado = row.Cells["Estado"].Value.ToString();
                }

            }
            MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dgview_paquetes.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgview_paquetes.SelectedRows[0];
                //variable que almacena la fila seleccionada
                int paqueteId = (int)filaSeleccionada.Cells["Id"].Value;
                //obtenemos el id de el paquete de la celda "Id" de la fila seleccionada
                var paqueteAEliminar = DatosGlobales.Paquetes.FirstOrDefault(p => p.Id == paqueteId);
                //buscamos el paquete en la lista global de paquetes que coincida con el id obtenido
                if (paqueteAEliminar != null)
                //si el paquete no es nulo, lo eliminamos de la lista global de paquetes
                {
                    DatosGlobales.Paquetes.Remove(paqueteAEliminar);
                    //actualizamos el datagridview para reflejar los cambios
                    CargarPaquetes(DatosGlobales.Paquetes);
                    //cargamos los paquetes de nuevo
                    MessageBox.Show("Paquete eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mensaje que dice que ya se borro el paquete correctamente
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paquete para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //si no se selecciono ningun paquete, mostramos un mensaje de error
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar a la sección de paquetes?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();//cerramos esta ventana y regresamos al form anterior osea el SPaquetes
            }
        }

        private void dgview_paquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
