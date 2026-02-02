namespace RepromosRA
{
    partial class fm_SPaquetes_Recepcion
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbox_nombre = new TextBox();
            dtime_fecha = new DateTimePicker();
            cbox_proveedor = new ComboBox();
            cbox_estado = new ComboBox();
            btn_registrarPaq = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 76);
            label2.Name = "label2";
            label2.Size = new Size(445, 28);
            label2.TabIndex = 9;
            label2.Text = "Registro de recepcion de paquetes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(184, 9);
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
            btn_regresar.Location = new Point(9, 394);
            btn_regresar.Margin = new Padding(0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(146, 47);
            btn_regresar.TabIndex = 6;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(223, 127);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 11;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label4.Location = new Point(223, 182);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 12;
            label4.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(223, 282);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 13;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold);
            label6.Location = new Point(223, 235);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 14;
            label6.Text = "Estado:";
            // 
            // tbox_nombre
            // 
            tbox_nombre.Location = new Point(322, 127);
            tbox_nombre.Name = "tbox_nombre";
            tbox_nombre.Size = new Size(187, 27);
            tbox_nombre.TabIndex = 1;
            // 
            // dtime_fecha
            // 
            dtime_fecha.CalendarFont = new Font("MT Extra", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 2);
            dtime_fecha.Cursor = Cursors.Hand;
            dtime_fecha.Format = DateTimePickerFormat.Short;
            dtime_fecha.Location = new Point(305, 282);
            dtime_fecha.Name = "dtime_fecha";
            dtime_fecha.Size = new Size(123, 27);
            dtime_fecha.TabIndex = 4;
            // 
            // cbox_proveedor
            // 
            cbox_proveedor.FormattingEnabled = true;
            cbox_proveedor.Location = new Point(350, 177);
            cbox_proveedor.Name = "cbox_proveedor";
            cbox_proveedor.Size = new Size(151, 28);
            cbox_proveedor.TabIndex = 2;
            // 
            // cbox_estado
            // 
            cbox_estado.FormattingEnabled = true;
            cbox_estado.Location = new Point(314, 230);
            cbox_estado.Name = "cbox_estado";
            cbox_estado.Size = new Size(151, 28);
            cbox_estado.TabIndex = 3;
            // 
            // btn_registrarPaq
            // 
            btn_registrarPaq.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_registrarPaq.BackColor = Color.DeepSkyBlue;
            btn_registrarPaq.Cursor = Cursors.Hand;
            btn_registrarPaq.FlatAppearance.BorderColor = Color.DarkRed;
            btn_registrarPaq.FlatStyle = FlatStyle.Flat;
            btn_registrarPaq.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_registrarPaq.Location = new Point(202, 332);
            btn_registrarPaq.Margin = new Padding(0);
            btn_registrarPaq.Name = "btn_registrarPaq";
            btn_registrarPaq.Size = new Size(332, 47);
            btn_registrarPaq.TabIndex = 5;
            btn_registrarPaq.Text = "Registrar paquete";
            btn_registrarPaq.UseVisualStyleBackColor = false;
            btn_registrarPaq.Click += btn_registrarPaq_Click;
            // 
            // fm_SPaquetes_Recepcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_registrarPaq);
            Controls.Add(cbox_estado);
            Controls.Add(cbox_proveedor);
            Controls.Add(dtime_fecha);
            Controls.Add(tbox_nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_regresar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SPaquetes_Recepcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SPaquetes_Recepcion";
            Load += fm_SPaquetes_Recepcion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_regresar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbox_nombre;
        private DateTimePicker dtime_fecha;
        private ComboBox cbox_proveedor;
        private ComboBox cbox_estado;
        private Button btn_registrarPaq;
    }
}