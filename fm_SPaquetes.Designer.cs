namespace RepromosRA
{
    partial class fm_SPaquetes
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
            btn_regresar = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_fmEnvioPaq = new Button();
            btn_fmRecepcionPaq = new Button();
            btn_fmPaquetesGeneral = new Button();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 32F, FontStyle.Bold);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 67);
            label1.TabIndex = 5;
            label1.Text = "PackManager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 76);
            label2.Name = "label2";
            label2.Size = new Size(270, 28);
            label2.TabIndex = 7;
            label2.Text = "Seccion de paquetes";
            // 
            // btn_fmEnvioPaq
            // 
            btn_fmEnvioPaq.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmEnvioPaq.BackColor = Color.Cyan;
            btn_fmEnvioPaq.Cursor = Cursors.Hand;
            btn_fmEnvioPaq.FlatAppearance.BorderColor = Color.Tan;
            btn_fmEnvioPaq.FlatStyle = FlatStyle.Flat;
            btn_fmEnvioPaq.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmEnvioPaq.Location = new Point(211, 203);
            btn_fmEnvioPaq.Margin = new Padding(0);
            btn_fmEnvioPaq.Name = "btn_fmEnvioPaq";
            btn_fmEnvioPaq.Size = new Size(359, 51);
            btn_fmEnvioPaq.TabIndex = 9;
            btn_fmEnvioPaq.Text = "Envio de Paquetes";
            btn_fmEnvioPaq.UseVisualStyleBackColor = false;
            btn_fmEnvioPaq.Click += btn_fmEnvioPaq_Click;
            // 
            // btn_fmRecepcionPaq
            // 
            btn_fmRecepcionPaq.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmRecepcionPaq.BackColor = Color.Cyan;
            btn_fmRecepcionPaq.Cursor = Cursors.Hand;
            btn_fmRecepcionPaq.FlatAppearance.BorderColor = Color.Tan;
            btn_fmRecepcionPaq.FlatStyle = FlatStyle.Flat;
            btn_fmRecepcionPaq.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmRecepcionPaq.Location = new Point(211, 141);
            btn_fmRecepcionPaq.Margin = new Padding(0);
            btn_fmRecepcionPaq.Name = "btn_fmRecepcionPaq";
            btn_fmRecepcionPaq.Size = new Size(359, 51);
            btn_fmRecepcionPaq.TabIndex = 8;
            btn_fmRecepcionPaq.Text = "Recepcion de Paquetes";
            btn_fmRecepcionPaq.UseVisualStyleBackColor = false;
            btn_fmRecepcionPaq.Click += btn_fmRecepcionPaq_Click;
            // 
            // btn_fmPaquetesGeneral
            // 
            btn_fmPaquetesGeneral.AccessibleDescription = "Ir a la seccion de paquetes";
            btn_fmPaquetesGeneral.BackColor = Color.LightCyan;
            btn_fmPaquetesGeneral.Cursor = Cursors.Hand;
            btn_fmPaquetesGeneral.FlatAppearance.BorderColor = Color.Tan;
            btn_fmPaquetesGeneral.FlatStyle = FlatStyle.Flat;
            btn_fmPaquetesGeneral.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btn_fmPaquetesGeneral.Location = new Point(211, 271);
            btn_fmPaquetesGeneral.Margin = new Padding(0);
            btn_fmPaquetesGeneral.Name = "btn_fmPaquetesGeneral";
            btn_fmPaquetesGeneral.Size = new Size(359, 51);
            btn_fmPaquetesGeneral.TabIndex = 10;
            btn_fmPaquetesGeneral.Text = "Todos los paquetes";
            btn_fmPaquetesGeneral.UseVisualStyleBackColor = false;
            // 
            // fm_SPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_fmPaquetesGeneral);
            Controls.Add(btn_fmEnvioPaq);
            Controls.Add(btn_fmRecepcionPaq);
            Controls.Add(label2);
            Controls.Add(btn_regresar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SPaquetes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SPaquetes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_regresar;
        private Label label1;
        private Label label2;
        private Button btn_fmEnvioPaq;
        private Button btn_fmRecepcionPaq;
        private Button btn_fmPaquetesGeneral;
    }
}