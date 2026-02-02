namespace RepromosRA
{
    public partial class fm_inicio : Form
    {
        public fm_inicio()
        {
            InitializeComponent();
        }

        private void fm_inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            //cerramos el programa en total
        }

        private void btn_fmpaquetes_Click(object sender, EventArgs e)
        {
            fm_SPaquetes seccionPaquetes = new fm_SPaquetes();
            //creamos una instancia para la seccion de los paquetes
            seccionPaquetes.ShowDialog();
            //por medio de la instancia usamos el metodo showdialog para abrir el form y 
            //por el show dialog, no se permite interactuar con este form al mismo tiempo que esta abierto
        }
    }
}
