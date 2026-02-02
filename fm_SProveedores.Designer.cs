namespace RepromosRA
{
    partial class fm_SProveedores
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
            label2 = new Label();
            label1 = new Label();
            dgview_proveedores = new DataGridView();
            btn_regresar = new Button();
            tbox_nombre = new TextBox();
            label3 = new Label();
            tbox_contacto = new TextBox();
            label4 = new Label();
            tbox_telefono = new TextBox();
            label5 = new Label();
            btn_registrarProv = new Button();
            label6 = new Label();
            tbox_direccion = new TextBox();
            label7 = new Label();
            tbox_filtroId = new TextBox();
            label8 = new Label();
            btn_borrarProv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgview_proveedores).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.8F, FontStyle.Bold);
            label2.Location = new Point(389, 76);
            label2.Name = "label2";
            label2.Size = new Size(529, 26);
            label2.TabIndex = 3;
            label2.Text = "Administra a tus proveedores y su informacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 2;
            label1.Text = "PackManager";
            // 
            // dgview_proveedores
            // 
            dgview_proveedores.AllowUserToAddRows = false;
            dgview_proveedores.BackgroundColor = SystemColors.ButtonFace;
            dgview_proveedores.BorderStyle = BorderStyle.None;
            dgview_proveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgview_proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgview_proveedores.GridColor = SystemColors.Info;
            dgview_proveedores.Location = new Point(636, 181);
            dgview_proveedores.Name = "dgview_proveedores";
            dgview_proveedores.RowHeadersWidth = 51;
            dgview_proveedores.Size = new Size(621, 382);
            dgview_proveedores.TabIndex = 7;
            // 
            // btn_regresar
            // 
            btn_regresar.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_regresar.BackColor = Color.Yellow;
            btn_regresar.Cursor = Cursors.Hand;
            btn_regresar.FlatAppearance.BorderColor = Color.DarkRed;
            btn_regresar.FlatStyle = FlatStyle.Flat;
            btn_regresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_regresar.Location = new Point(9, 617);
            btn_regresar.Margin = new Padding(0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(181, 47);
            btn_regresar.TabIndex = 8;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // tbox_nombre
            // 
            tbox_nombre.Location = new Point(168, 263);
            tbox_nombre.Name = "tbox_nombre";
            tbox_nombre.Size = new Size(249, 27);
            tbox_nombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(65, 263);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // tbox_contacto
            // 
            tbox_contacto.Location = new Point(178, 315);
            tbox_contacto.Name = "tbox_contacto";
            tbox_contacto.Size = new Size(239, 27);
            tbox_contacto.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label4.Location = new Point(65, 315);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 15;
            label4.Text = "Contacto:";
            // 
            // tbox_telefono
            // 
            tbox_telefono.Location = new Point(175, 372);
            tbox_telefono.Name = "tbox_telefono";
            tbox_telefono.Size = new Size(242, 27);
            tbox_telefono.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(65, 372);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 17;
            label5.Text = "Telefono:";
            // 
            // btn_registrarProv
            // 
            btn_registrarProv.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_registrarProv.BackColor = Color.DeepSkyBlue;
            btn_registrarProv.Cursor = Cursors.Hand;
            btn_registrarProv.FlatAppearance.BorderColor = Color.DarkRed;
            btn_registrarProv.FlatStyle = FlatStyle.Flat;
            btn_registrarProv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_registrarProv.Location = new Point(104, 469);
            btn_registrarProv.Margin = new Padding(0);
            btn_registrarProv.Name = "btn_registrarProv";
            btn_registrarProv.Size = new Size(332, 47);
            btn_registrarProv.TabIndex = 5;
            btn_registrarProv.Text = "Registrar proveedor";
            btn_registrarProv.UseVisualStyleBackColor = false;
            btn_registrarProv.Click += btn_registrarProv_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.8F, FontStyle.Bold);
            label6.Location = new Point(134, 204);
            label6.Name = "label6";
            label6.Size = new Size(260, 26);
            label6.TabIndex = 19;
            label6.Text = "Formulario de registro";
            // 
            // tbox_direccion
            // 
            tbox_direccion.Location = new Point(185, 424);
            tbox_direccion.Name = "tbox_direccion";
            tbox_direccion.Size = new Size(232, 27);
            tbox_direccion.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label7.Location = new Point(68, 424);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 21;
            label7.Text = "Direccion:";
            // 
            // tbox_filtroId
            // 
            tbox_filtroId.Location = new Point(886, 137);
            tbox_filtroId.Name = "tbox_filtroId";
            tbox_filtroId.Size = new Size(249, 27);
            tbox_filtroId.TabIndex = 6;
            tbox_filtroId.TextChanged += tbox_filtroId_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label8.Location = new Point(735, 137);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 23;
            label8.Text = "Filtrar por id:";
            // 
            // btn_borrarProv
            // 
            btn_borrarProv.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_borrarProv.BackColor = Color.Red;
            btn_borrarProv.Cursor = Cursors.Hand;
            btn_borrarProv.FlatAppearance.BorderColor = Color.DarkRed;
            btn_borrarProv.FlatStyle = FlatStyle.Flat;
            btn_borrarProv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_borrarProv.Location = new Point(817, 590);
            btn_borrarProv.Margin = new Padding(0);
            btn_borrarProv.Name = "btn_borrarProv";
            btn_borrarProv.Size = new Size(332, 47);
            btn_borrarProv.TabIndex = 7;
            btn_borrarProv.Text = "Borrar Proveedor";
            btn_borrarProv.UseVisualStyleBackColor = false;
            btn_borrarProv.Click += btn_borrarProv_Click;
            // 
            // fm_SProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1300, 673);
            Controls.Add(btn_borrarProv);
            Controls.Add(tbox_filtroId);
            Controls.Add(label8);
            Controls.Add(tbox_direccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_registrarProv);
            Controls.Add(tbox_telefono);
            Controls.Add(label5);
            Controls.Add(tbox_contacto);
            Controls.Add(label4);
            Controls.Add(tbox_nombre);
            Controls.Add(label3);
            Controls.Add(btn_regresar);
            Controls.Add(dgview_proveedores);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SProveedores";
            Load += fm_SProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgview_proveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgview_proveedores;
        private Button btn_regresar;
        private TextBox tbox_nombre;
        private Label label3;
        private TextBox tbox_contacto;
        private Label label4;
        private TextBox tbox_telefono;
        private Label label5;
        private Button btn_registrarProv;
        private Label label6;
        private TextBox tbox_direccion;
        private Label label7;
        private TextBox tbox_filtroId;
        private Label label8;
        private Button btn_borrarProv;
    }
}