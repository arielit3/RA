namespace RepromosRA
{
    partial class fm_SClientes
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
            btn_borrarProv = new Button();
            tbox_filtroId = new TextBox();
            label8 = new Label();
            tbox_direccion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btn_registrarProv = new Button();
            tbox_telefono = new TextBox();
            label5 = new Label();
            tbox_nombre = new TextBox();
            label3 = new Label();
            btn_regresar = new Button();
            dgview_clientes = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgview_clientes).BeginInit();
            SuspendLayout();
            // 
            // btn_borrarProv
            // 
            btn_borrarProv.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_borrarProv.BackColor = Color.Red;
            btn_borrarProv.Cursor = Cursors.Hand;
            btn_borrarProv.FlatAppearance.BorderColor = Color.DarkRed;
            btn_borrarProv.FlatStyle = FlatStyle.Flat;
            btn_borrarProv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_borrarProv.Location = new Point(816, 590);
            btn_borrarProv.Margin = new Padding(0);
            btn_borrarProv.Name = "btn_borrarProv";
            btn_borrarProv.Size = new Size(332, 47);
            btn_borrarProv.TabIndex = 5;
            btn_borrarProv.Text = "Borrar cliente";
            btn_borrarProv.UseVisualStyleBackColor = false;
            btn_borrarProv.Click += btn_borrarProv_Click;
            // 
            // tbox_filtroId
            // 
            tbox_filtroId.Location = new Point(885, 137);
            tbox_filtroId.Name = "tbox_filtroId";
            tbox_filtroId.Size = new Size(249, 27);
            tbox_filtroId.TabIndex = 4;
            tbox_filtroId.TextChanged += tbox_filtroId_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label8.Location = new Point(734, 137);
            label8.Name = "label8";
            label8.Size = new Size(145, 23);
            label8.TabIndex = 40;
            label8.Text = "Filtrar por id:";
            // 
            // tbox_direccion
            // 
            tbox_direccion.Location = new Point(184, 356);
            tbox_direccion.Name = "tbox_direccion";
            tbox_direccion.Size = new Size(232, 27);
            tbox_direccion.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label7.Location = new Point(67, 356);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 39;
            label7.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.8F, FontStyle.Bold);
            label6.Location = new Point(133, 204);
            label6.Name = "label6";
            label6.Size = new Size(260, 26);
            label6.TabIndex = 38;
            label6.Text = "Formulario de registro";
            // 
            // btn_registrarProv
            // 
            btn_registrarProv.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_registrarProv.BackColor = Color.DeepSkyBlue;
            btn_registrarProv.Cursor = Cursors.Hand;
            btn_registrarProv.FlatAppearance.BorderColor = Color.DarkRed;
            btn_registrarProv.FlatStyle = FlatStyle.Flat;
            btn_registrarProv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_registrarProv.Location = new Point(103, 401);
            btn_registrarProv.Margin = new Padding(0);
            btn_registrarProv.Name = "btn_registrarProv";
            btn_registrarProv.Size = new Size(332, 47);
            btn_registrarProv.TabIndex = 30;
            btn_registrarProv.Text = "Registrar cliente";
            btn_registrarProv.UseVisualStyleBackColor = false;
            btn_registrarProv.Click += btn_registrarProv_Click;
            // 
            // tbox_telefono
            // 
            tbox_telefono.Location = new Point(174, 308);
            tbox_telefono.Name = "tbox_telefono";
            tbox_telefono.Size = new Size(242, 27);
            tbox_telefono.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(64, 308);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 37;
            label5.Text = "Telefono:";
            // 
            // tbox_nombre
            // 
            tbox_nombre.Location = new Point(167, 263);
            tbox_nombre.Name = "tbox_nombre";
            tbox_nombre.Size = new Size(249, 27);
            tbox_nombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(64, 263);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 35;
            label3.Text = "Nombre:";
            // 
            // btn_regresar
            // 
            btn_regresar.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_regresar.BackColor = Color.Yellow;
            btn_regresar.Cursor = Cursors.Hand;
            btn_regresar.FlatAppearance.BorderColor = Color.DarkRed;
            btn_regresar.FlatStyle = FlatStyle.Flat;
            btn_regresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_regresar.Location = new Point(8, 617);
            btn_regresar.Margin = new Padding(0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(181, 47);
            btn_regresar.TabIndex = 6;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // dgview_clientes
            // 
            dgview_clientes.AllowUserToAddRows = false;
            dgview_clientes.BackgroundColor = SystemColors.ButtonFace;
            dgview_clientes.BorderStyle = BorderStyle.None;
            dgview_clientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgview_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgview_clientes.GridColor = SystemColors.Info;
            dgview_clientes.Location = new Point(635, 181);
            dgview_clientes.Name = "dgview_clientes";
            dgview_clientes.RowHeadersWidth = 51;
            dgview_clientes.Size = new Size(621, 382);
            dgview_clientes.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.8F, FontStyle.Bold);
            label2.Location = new Point(419, 76);
            label2.Name = "label2";
            label2.Size = new Size(479, 26);
            label2.TabIndex = 28;
            label2.Text = "Administra a tus clientes y su informacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 25;
            label1.Text = "PackManager";
            // 
            // fm_SClientes
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
            Controls.Add(tbox_nombre);
            Controls.Add(label3);
            Controls.Add(btn_regresar);
            Controls.Add(dgview_clientes);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SClientes";
            Load += fm_SClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgview_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_borrarProv;
        private TextBox tbox_filtroId;
        private Label label8;
        private TextBox tbox_direccion;
        private Label label7;
        private Label label6;
        private Button btn_registrarProv;
        private TextBox tbox_telefono;
        private Label label5;
        private TextBox tbox_nombre;
        private Label label3;
        private Button btn_regresar;
        private DataGridView dgview_clientes;
        private Label label2;
        private Label label1;
    }
}