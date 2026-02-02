namespace RepromosRA
{
    partial class fm_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btn_fmpaquetes = new Button();
            btn_fmproveedores = new Button();
            btn_fmclientes = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 0;
            label1.Text = "PackManager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.8F, FontStyle.Bold);
            label2.Location = new Point(150, 76);
            label2.Name = "label2";
            label2.Size = new Size(481, 26);
            label2.TabIndex = 1;
            label2.Text = "Gestiona paquetes, proveedores y clientes";
            // 
            // btn_fmpaquetes
            // 
            btn_fmpaquetes.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmpaquetes.BackColor = Color.OldLace;
            btn_fmpaquetes.Cursor = Cursors.Hand;
            btn_fmpaquetes.FlatAppearance.BorderColor = Color.Tan;
            btn_fmpaquetes.FlatStyle = FlatStyle.Flat;
            btn_fmpaquetes.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmpaquetes.Location = new Point(209, 138);
            btn_fmpaquetes.Margin = new Padding(0);
            btn_fmpaquetes.Name = "btn_fmpaquetes";
            btn_fmpaquetes.Size = new Size(359, 74);
            btn_fmpaquetes.TabIndex = 1;
            btn_fmpaquetes.Text = "Seccion de Paquetes";
            btn_fmpaquetes.UseVisualStyleBackColor = false;
            btn_fmpaquetes.Click += btn_fmpaquetes_Click;
            // 
            // btn_fmproveedores
            // 
            btn_fmproveedores.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmproveedores.BackColor = Color.OldLace;
            btn_fmproveedores.Cursor = Cursors.Hand;
            btn_fmproveedores.FlatAppearance.BorderColor = Color.Tan;
            btn_fmproveedores.FlatStyle = FlatStyle.Flat;
            btn_fmproveedores.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmproveedores.Location = new Point(209, 228);
            btn_fmproveedores.Margin = new Padding(0);
            btn_fmproveedores.Name = "btn_fmproveedores";
            btn_fmproveedores.Size = new Size(359, 74);
            btn_fmproveedores.TabIndex = 2;
            btn_fmproveedores.Text = "Seccion de Proveedores";
            btn_fmproveedores.UseVisualStyleBackColor = false;
            btn_fmproveedores.Click += btn_fmproveedores_Click;
            // 
            // btn_fmclientes
            // 
            btn_fmclientes.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmclientes.BackColor = Color.OldLace;
            btn_fmclientes.Cursor = Cursors.Hand;
            btn_fmclientes.FlatAppearance.BorderColor = Color.Tan;
            btn_fmclientes.FlatStyle = FlatStyle.Flat;
            btn_fmclientes.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmclientes.Location = new Point(209, 324);
            btn_fmclientes.Margin = new Padding(0);
            btn_fmclientes.Name = "btn_fmclientes";
            btn_fmclientes.Size = new Size(359, 74);
            btn_fmclientes.TabIndex = 3;
            btn_fmclientes.Text = "Seccion de Clientes";
            btn_fmclientes.UseVisualStyleBackColor = false;
            btn_fmclientes.Click += btn_fmclientes_Click;
            // 
            // btn_salir
            // 
            btn_salir.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_salir.BackColor = Color.Red;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderColor = Color.DarkRed;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_salir.Location = new Point(681, 9);
            btn_salir.Margin = new Padding(0);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(110, 47);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Cerrar";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // fm_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salir);
            Controls.Add(btn_fmclientes);
            Controls.Add(btn_fmproveedores);
            Controls.Add(btn_fmpaquetes);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += fm_inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_fmpaquetes;
        private Button btn_fmproveedores;
        private Button btn_fmclientes;
        private Button btn_salir;
    }
}
