namespace RepromosRA
{
    partial class FrmProveedores
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
            btnRegresar = new Button();
            label6 = new Label();
            labelByUser = new Label();
            labelWelcome = new Label();
            label1 = new Label();
            pBxLogo = new PictureBox();
            dgvProveedores = new DataGridView();
            btnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(694, 431);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 25;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 110);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 42;
            label6.Text = "Proveedores";
            // 
            // labelByUser
            // 
            labelByUser.AutoSize = true;
            labelByUser.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelByUser.Location = new Point(405, 52);
            labelByUser.Name = "labelByUser";
            labelByUser.Size = new Size(27, 28);
            labelByUser.TabIndex = 41;
            labelByUser.Text = ".";
            labelByUser.Click += labelByUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(282, 52);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(117, 28);
            labelWelcome.TabIndex = 40;
            labelWelcome.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 10);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 39;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(608, 10);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 43;
            pBxLogo.TabStop = false;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(40, 131);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(584, 188);
            dgvProveedores.TabIndex = 44;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(333, 423);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 53;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 352);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 52;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 352);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 51;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 352);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 50;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 352);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 49;
            label2.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(545, 375);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 48;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(394, 375);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 47;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(233, 375);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 46;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 375);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 45;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(671, 222);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 55;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(671, 169);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 54;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(dgvProveedores);
            Controls.Add(pBxLogo);
            Controls.Add(label6);
            Controls.Add(labelByUser);
            Controls.Add(labelWelcome);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label label6;
        private Label labelByUser;
        private Label labelWelcome;
        private Label label1;
        private PictureBox pBxLogo;
        private DataGridView dgvProveedores;
        private Button btnGuardar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnEliminar;
    }
}