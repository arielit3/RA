namespace RepromosRA
{
    partial class FrmRecepcionPaquetes
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
            pBxLogo = new PictureBox();
            txtBxCodigoRastreo = new TextBox();
            lblCodigoRastreo = new Label();
            label1 = new Label();
            labelWelcome = new Label();
            labelByUser = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbProveedor = new ComboBox();
            label3 = new Label();
            txtBxPeso = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDescripcion = new TextBox();
            btnRegisterUser = new Button();
            label6 = new Label();
            btnRegresar = new Button();
            btnAdministrarClientes = new Button();
            btnAdministrarProveedores = new Button();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            SuspendLayout();
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(608, 12);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 8;
            pBxLogo.TabStop = false;
            // 
            // txtBxCodigoRastreo
            // 
            txtBxCodigoRastreo.Location = new Point(178, 187);
            txtBxCodigoRastreo.Name = "txtBxCodigoRastreo";
            txtBxCodigoRastreo.Size = new Size(167, 27);
            txtBxCodigoRastreo.TabIndex = 9;
            txtBxCodigoRastreo.TextChanged += txtBxCodigoRastreo_TextChanged;
            // 
            // lblCodigoRastreo
            // 
            lblCodigoRastreo.AutoSize = true;
            lblCodigoRastreo.Location = new Point(178, 164);
            lblCodigoRastreo.Name = "lblCodigoRastreo";
            lblCodigoRastreo.Size = new Size(136, 20);
            lblCodigoRastreo.TabIndex = 10;
            lblCodigoRastreo.Text = "Codigo de Rastreo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 12);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 11;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(286, 54);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(117, 28);
            labelWelcome.TabIndex = 12;
            labelWelcome.Text = "Welcome";
            // 
            // labelByUser
            // 
            labelByUser.AutoSize = true;
            labelByUser.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelByUser.Location = new Point(409, 54);
            labelByUser.Name = "labelByUser";
            labelByUser.Size = new Size(27, 28);
            labelByUser.TabIndex = 13;
            labelByUser.Text = ".";
            labelByUser.Click += labelByUser_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(376, 186);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(167, 28);
            cmbCliente.TabIndex = 14;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 163);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 15;
            label2.Text = "Lista de Clientes:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(178, 263);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(167, 28);
            cmbProveedor.TabIndex = 16;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 240);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 17;
            label3.Text = "Lista de Proveedores:";
            // 
            // txtBxPeso
            // 
            txtBxPeso.Location = new Point(376, 263);
            txtBxPeso.Name = "txtBxPeso";
            txtBxPeso.Size = new Size(173, 27);
            txtBxPeso.TabIndex = 18;
            txtBxPeso.TextChanged += txtBxPeso_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 19;
            label4.Text = "Peso (KG):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 309);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 20;
            label5.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(279, 332);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 27);
            txtDescripcion.TabIndex = 21;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.BackColor = Color.Chartreuse;
            btnRegisterUser.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegisterUser.Location = new Point(311, 400);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(125, 50);
            btnRegisterUser.TabIndex = 22;
            btnRegisterUser.Text = "Registrar Recepción";
            btnRegisterUser.UseVisualStyleBackColor = false;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(246, 116);
            label6.Name = "label6";
            label6.Size = new Size(218, 18);
            label6.TabIndex = 23;
            label6.Text = "Recepción de Paquetes";
            label6.Click += label6_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(694, 501);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 24;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAdministrarClientes
            // 
            btnAdministrarClientes.BackColor = Color.FromArgb(128, 128, 255);
            btnAdministrarClientes.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdministrarClientes.Location = new Point(120, 480);
            btnAdministrarClientes.Name = "btnAdministrarClientes";
            btnAdministrarClientes.Size = new Size(125, 50);
            btnAdministrarClientes.TabIndex = 25;
            btnAdministrarClientes.Text = "Administrar Clientes";
            btnAdministrarClientes.UseVisualStyleBackColor = false;
            btnAdministrarClientes.Click += btnAdministrarClientes_Click;
            // 
            // btnAdministrarProveedores
            // 
            btnAdministrarProveedores.BackColor = Color.FromArgb(128, 128, 255);
            btnAdministrarProveedores.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdministrarProveedores.Location = new Point(278, 480);
            btnAdministrarProveedores.Name = "btnAdministrarProveedores";
            btnAdministrarProveedores.Size = new Size(125, 50);
            btnAdministrarProveedores.TabIndex = 26;
            btnAdministrarProveedores.Text = "Administrar Proveedores";
            btnAdministrarProveedores.UseVisualStyleBackColor = false;
            btnAdministrarProveedores.Click += btnAdministrarProveedores_Click;
            // 
            // FrmRecepcionPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(btnAdministrarProveedores);
            Controls.Add(btnAdministrarClientes);
            Controls.Add(btnRegresar);
            Controls.Add(label6);
            Controls.Add(btnRegisterUser);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBxPeso);
            Controls.Add(label3);
            Controls.Add(cmbProveedor);
            Controls.Add(label2);
            Controls.Add(cmbCliente);
            Controls.Add(labelByUser);
            Controls.Add(labelWelcome);
            Controls.Add(label1);
            Controls.Add(lblCodigoRastreo);
            Controls.Add(txtBxCodigoRastreo);
            Controls.Add(pBxLogo);
            Name = "FrmRecepcionPaquetes";
            Text = "FrmRecepcionPaquetes";
            Load += FrmRecepcionPaquetes_Load;
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBxLogo;
        private TextBox txtBxCodigoRastreo;
        private Label lblCodigoRastreo;
        private Label label1;
        private Label labelWelcome;
        private Label labelByUser;
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbProveedor;
        private Label label3;
        private TextBox txtBxPeso;
        private Label label4;
        private Label label5;
        private TextBox txtDescripcion;
        private Button btnRegisterUser;
        private Label label6;
        private Button btnRegresar;
        private Button btnAdministrarClientes;
        private Button btnAdministrarProveedores;
    }
}