namespace RepromosRA
{
    partial class FrmTrackingPaquetes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            labelByUser = new Label();
            labelWelcome = new Label();
            label1 = new Label();
            pBxLogo = new PictureBox();
            lblCodigoRastreo = new Label();
            txtBxCodigoRastreo = new TextBox();
            btnBuscar = new Button();
            btnRegistrarEnvio = new Button();
            btnMarcarEntregado = new Button();
            btnRegresar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblEstado = new Label();
            lblClienteID = new Label();
            lblProveedorID = new Label();
            lblFechas = new Label();
            dgvPaquetes = new DataGridView();
            btnRefrescarDataGridView = new Button();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(502, 121);
            label6.Name = "label6";
            label6.Size = new Size(178, 18);
            label6.TabIndex = 28;
            label6.Text = "Tracking Paquetes";
            // 
            // labelByUser
            // 
            labelByUser.AutoSize = true;
            labelByUser.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelByUser.Location = new Point(653, 54);
            labelByUser.Name = "labelByUser";
            labelByUser.Size = new Size(27, 28);
            labelByUser.TabIndex = 27;
            labelByUser.Text = ".";
            labelByUser.Click += labelByUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(530, 54);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(117, 28);
            labelWelcome.TabIndex = 26;
            labelWelcome.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 12);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 25;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(931, 12);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 24;
            pBxLogo.TabStop = false;
            // 
            // lblCodigoRastreo
            // 
            lblCodigoRastreo.AutoSize = true;
            lblCodigoRastreo.Location = new Point(7, 225);
            lblCodigoRastreo.Name = "lblCodigoRastreo";
            lblCodigoRastreo.Size = new Size(136, 20);
            lblCodigoRastreo.TabIndex = 30;
            lblCodigoRastreo.Text = "Codigo de Rastreo:";
            // 
            // txtBxCodigoRastreo
            // 
            txtBxCodigoRastreo.Location = new Point(7, 248);
            txtBxCodigoRastreo.Name = "txtBxCodigoRastreo";
            txtBxCodigoRastreo.Size = new Size(167, 27);
            txtBxCodigoRastreo.TabIndex = 29;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Chartreuse;
            btnBuscar.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(409, 467);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 50);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegistrarEnvio
            // 
            btnRegistrarEnvio.BackColor = Color.Chartreuse;
            btnRegistrarEnvio.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrarEnvio.Location = new Point(671, 467);
            btnRegistrarEnvio.Name = "btnRegistrarEnvio";
            btnRegistrarEnvio.Size = new Size(125, 50);
            btnRegistrarEnvio.TabIndex = 32;
            btnRegistrarEnvio.Text = "Registrar Envio";
            btnRegistrarEnvio.UseVisualStyleBackColor = false;
            btnRegistrarEnvio.Click += btnRegistrarEnvio_Click;
            // 
            // btnMarcarEntregado
            // 
            btnMarcarEntregado.BackColor = Color.Chartreuse;
            btnMarcarEntregado.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMarcarEntregado.Location = new Point(540, 467);
            btnMarcarEntregado.Name = "btnMarcarEntregado";
            btnMarcarEntregado.Size = new Size(125, 50);
            btnMarcarEntregado.TabIndex = 33;
            btnMarcarEntregado.Text = "Marcar Entregado";
            btnMarcarEntregado.UseVisualStyleBackColor = false;
            btnMarcarEntregado.Click += btnMarcarEntregado_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(1017, 512);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 34;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 188);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 35;
            label2.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 234);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 36;
            label3.Text = "ID cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 276);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 37;
            label4.Text = "ID Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 320);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 38;
            label5.Text = "Fechas:";
            label5.Click += label5_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(257, 188);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(15, 20);
            lblEstado.TabIndex = 39;
            lblEstado.Text = "-";
            lblEstado.Click += lblEstado_Click;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(274, 234);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(15, 20);
            lblClienteID.TabIndex = 40;
            lblClienteID.Text = "-";
            lblClienteID.Click += lblClienteID_Click;
            // 
            // lblProveedorID
            // 
            lblProveedorID.AutoSize = true;
            lblProveedorID.Location = new Point(295, 276);
            lblProveedorID.Name = "lblProveedorID";
            lblProveedorID.Size = new Size(15, 20);
            lblProveedorID.TabIndex = 41;
            lblProveedorID.Text = "-";
            lblProveedorID.Click += lblProveedorID_Click;
            // 
            // lblFechas
            // 
            lblFechas.AutoSize = true;
            lblFechas.Location = new Point(252, 320);
            lblFechas.Name = "lblFechas";
            lblFechas.Size = new Size(15, 20);
            lblFechas.TabIndex = 42;
            lblFechas.Text = "-";
            lblFechas.Click += lblFechas_Click;
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(570, 174);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.Size = new Size(541, 217);
            dgvPaquetes.TabIndex = 43;
            dgvPaquetes.CellContentClick += dgvPaquetes_CellContentClick;
            // 
            // btnRefrescarDataGridView
            // 
            btnRefrescarDataGridView.Location = new Point(836, 397);
            btnRefrescarDataGridView.Name = "btnRefrescarDataGridView";
            btnRefrescarDataGridView.Size = new Size(94, 29);
            btnRefrescarDataGridView.TabIndex = 44;
            btnRefrescarDataGridView.Text = "Refrescar";
            btnRefrescarDataGridView.UseVisualStyleBackColor = true;
            btnRefrescarDataGridView.Click += btnRefrescarDataGridView_Click;
            // 
            // FrmTrackingPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 553);
            Controls.Add(btnRefrescarDataGridView);
            Controls.Add(dgvPaquetes);
            Controls.Add(lblFechas);
            Controls.Add(lblProveedorID);
            Controls.Add(lblClienteID);
            Controls.Add(lblEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegresar);
            Controls.Add(btnMarcarEntregado);
            Controls.Add(btnRegistrarEnvio);
            Controls.Add(btnBuscar);
            Controls.Add(lblCodigoRastreo);
            Controls.Add(txtBxCodigoRastreo);
            Controls.Add(label6);
            Controls.Add(labelByUser);
            Controls.Add(labelWelcome);
            Controls.Add(label1);
            Controls.Add(pBxLogo);
            Name = "FrmTrackingPaquetes";
            Text = "FrmTrackingPaquetes";
            Load += FrmTrackingPaquetes_Load;
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label labelByUser;
        private Label labelWelcome;
        private Label label1;
        private PictureBox pBxLogo;
        private Label lblCodigoRastreo;
        private TextBox txtBxCodigoRastreo;
        private Button btnBuscar;
        private Button btnRegistrarEnvio;
        private Button btnMarcarEntregado;
        private Button btnRegresar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblEstado;
        private Label lblClienteID;
        private Label lblProveedorID;
        private Label lblFechas;
        private DataGridView dataGridView1;
        private DataGridView dgvPaquetes;
        private Button btnRefrescarDataGridView;
    }
}