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
        }

        private void btn_fmpaquetes_Click(object sender, EventArgs e)
        {
            fm_SPaquetes seccionPaquetes = new fm_SPaquetes();
            seccionPaquetes.ShowDialog();
        }
    }
}
