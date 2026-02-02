namespace RepromosRA
{
    partial class fm_SPaquetes_General
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
            btn_regresar = new Button();
            dgview_paquetes = new DataGridView();
            label3 = new Label();
            tbox_filtroID = new TextBox();
            btn_filtroRecibidos = new Button();
            btn_filtroEnviados = new Button();
            btn_filtroTodos = new Button();
            btn_borrar = new Button();
            btn_guardarCambios = new Button();
            btn_filtroRectificados = new Button();
            ((System.ComponentModel.ISupportInitialize)dgview_paquetes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 76);
            label2.Name = "label2";
            label2.Size = new Size(585, 28);
            label2.TabIndex = 9;
            label2.Text = "Gestiona todos tus paquetes al mismo tiempo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 8;
            label1.Text = "PackManager";
            // 
            // btn_regresar
            // 
            btn_regresar.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_regresar.BackColor = Color.Yellow;
            btn_regresar.Cursor = Cursors.Hand;
            btn_regresar.FlatAppearance.BorderColor = Color.DarkRed;
            btn_regresar.FlatStyle = FlatStyle.Flat;
            btn_regresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_regresar.Location = new Point(9, 517);
            btn_regresar.Margin = new Padding(0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(108, 40);
            btn_regresar.TabIndex = 6;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // dgview_paquetes
            // 
            dgview_paquetes.AllowUserToAddRows = false;
            dgview_paquetes.BackgroundColor = SystemColors.Window;
            dgview_paquetes.BorderStyle = BorderStyle.None;
            dgview_paquetes.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgview_paquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgview_paquetes.GridColor = SystemColors.Info;
            dgview_paquetes.Location = new Point(48, 229);
            dgview_paquetes.Name = "dgview_paquetes";
            dgview_paquetes.RowHeadersWidth = 51;
            dgview_paquetes.Size = new Size(825, 248);
            dgview_paquetes.TabIndex = 6;
            dgview_paquetes.CellContentClick += dgview_paquetes_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(283, 118);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 12;
            label3.Text = "Filtro por Id:";
            // 
            // tbox_filtroID
            // 
            tbox_filtroID.BorderStyle = BorderStyle.None;
            tbox_filtroID.Cursor = Cursors.IBeam;
            tbox_filtroID.Location = new Point(428, 118);
            tbox_filtroID.Name = "tbox_filtroID";
            tbox_filtroID.PlaceholderText = "Ingresa id";
            tbox_filtroID.Size = new Size(125, 20);
            tbox_filtroID.TabIndex = 1;
            tbox_filtroID.TextAlign = HorizontalAlignment.Center;
            tbox_filtroID.TextChanged += tbox_filtroID_TextChanged;
            // 
            // btn_filtroRecibidos
            // 
            btn_filtroRecibidos.AccessibleDescription = "Paquetes recibidos";
            btn_filtroRecibidos.BackColor = Color.PeachPuff;
            btn_filtroRecibidos.Cursor = Cursors.Hand;
            btn_filtroRecibidos.FlatAppearance.BorderColor = Color.Tan;
            btn_filtroRecibidos.FlatStyle = FlatStyle.Flat;
            btn_filtroRecibidos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_filtroRecibidos.Location = new Point(63, 161);
            btn_filtroRecibidos.Margin = new Padding(0);
            btn_filtroRecibidos.Name = "btn_filtroRecibidos";
            btn_filtroRecibidos.Size = new Size(173, 51);
            btn_filtroRecibidos.TabIndex = 2;
            btn_filtroRecibidos.Text = "Recibidos";
            btn_filtroRecibidos.UseVisualStyleBackColor = false;
            btn_filtroRecibidos.Click += btn_filtroRecibidos_Click;
            // 
            // btn_filtroEnviados
            // 
            btn_filtroEnviados.AccessibleDescription = "Paquetes enviados";
            btn_filtroEnviados.BackColor = Color.PeachPuff;
            btn_filtroEnviados.Cursor = Cursors.Hand;
            btn_filtroEnviados.FlatAppearance.BorderColor = Color.Tan;
            btn_filtroEnviados.FlatStyle = FlatStyle.Flat;
            btn_filtroEnviados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_filtroEnviados.Location = new Point(451, 161);
            btn_filtroEnviados.Margin = new Padding(0);
            btn_filtroEnviados.Name = "btn_filtroEnviados";
            btn_filtroEnviados.Size = new Size(173, 51);
            btn_filtroEnviados.TabIndex = 4;
            btn_filtroEnviados.Text = "Enviados";
            btn_filtroEnviados.UseVisualStyleBackColor = false;
            btn_filtroEnviados.Click += btn_filtroEnviados_Click;
            // 
            // btn_filtroTodos
            // 
            btn_filtroTodos.AccessibleDescription = "Todos los paquetes";
            btn_filtroTodos.BackColor = Color.PeachPuff;
            btn_filtroTodos.Cursor = Cursors.Hand;
            btn_filtroTodos.FlatAppearance.BorderColor = Color.Tan;
            btn_filtroTodos.FlatStyle = FlatStyle.Flat;
            btn_filtroTodos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_filtroTodos.Location = new Point(260, 161);
            btn_filtroTodos.Margin = new Padding(0);
            btn_filtroTodos.Name = "btn_filtroTodos";
            btn_filtroTodos.Size = new Size(173, 51);
            btn_filtroTodos.TabIndex = 3;
            btn_filtroTodos.Text = "Todos";
            btn_filtroTodos.UseVisualStyleBackColor = false;
            btn_filtroTodos.Click += btn_filtroTodos_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_borrar.BackColor = Color.Red;
            btn_borrar.Cursor = Cursors.Hand;
            btn_borrar.FlatAppearance.BorderColor = Color.DarkRed;
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_borrar.Location = new Point(237, 497);
            btn_borrar.Margin = new Padding(0);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(185, 47);
            btn_borrar.TabIndex = 7;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_guardarCambios
            // 
            btn_guardarCambios.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_guardarCambios.BackColor = Color.DeepSkyBlue;
            btn_guardarCambios.Cursor = Cursors.Hand;
            btn_guardarCambios.FlatAppearance.BorderColor = Color.DarkRed;
            btn_guardarCambios.FlatStyle = FlatStyle.Flat;
            btn_guardarCambios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_guardarCambios.Location = new Point(451, 497);
            btn_guardarCambios.Margin = new Padding(0);
            btn_guardarCambios.Name = "btn_guardarCambios";
            btn_guardarCambios.Size = new Size(185, 47);
            btn_guardarCambios.TabIndex = 8;
            btn_guardarCambios.Text = "Guardar Cambios";
            btn_guardarCambios.UseVisualStyleBackColor = false;
            btn_guardarCambios.Click += btn_guardarCambios_Click;
            // 
            // btn_filtroRectificados
            // 
            btn_filtroRectificados.AccessibleDescription = "Paquetes enviados";
            btn_filtroRectificados.BackColor = Color.PeachPuff;
            btn_filtroRectificados.Cursor = Cursors.Hand;
            btn_filtroRectificados.FlatAppearance.BorderColor = Color.Tan;
            btn_filtroRectificados.FlatStyle = FlatStyle.Flat;
            btn_filtroRectificados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_filtroRectificados.Location = new Point(647, 161);
            btn_filtroRectificados.Margin = new Padding(0);
            btn_filtroRectificados.Name = "btn_filtroRectificados";
            btn_filtroRectificados.Size = new Size(173, 51);
            btn_filtroRectificados.TabIndex = 5;
            btn_filtroRectificados.Text = "Rectificados";
            btn_filtroRectificados.UseVisualStyleBackColor = false;
            btn_filtroRectificados.Click += btn_filtroRectificados_Click;
            // 
            // fm_SPaquetes_General
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(927, 566);
            Controls.Add(btn_filtroRectificados);
            Controls.Add(btn_guardarCambios);
            Controls.Add(btn_borrar);
            Controls.Add(btn_filtroTodos);
            Controls.Add(btn_filtroEnviados);
            Controls.Add(btn_filtroRecibidos);
            Controls.Add(tbox_filtroID);
            Controls.Add(label3);
            Controls.Add(dgview_paquetes);
            Controls.Add(btn_regresar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SPaquetes_General";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SPaquetes_General";
            Load += fm_SPaquetes_General_Load;
            ((System.ComponentModel.ISupportInitialize)dgview_paquetes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_regresar;
        private DataGridView dgview_paquetes;
        private Label label3;
        private TextBox tbox_filtroID;
        private Button btn_filtroRecibidos;
        private Button btn_filtroEnviados;
        private Button btn_filtroTodos;
        private Button btn_borrar;
        private Button btn_guardarCambios;
        private Button btn_filtroRectificados;
    }
}