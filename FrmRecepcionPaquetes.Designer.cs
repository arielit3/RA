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
            textBox1 = new TextBox();
            lblCodigoRastreo = new Label();
            label1 = new Label();
            labelWelcome = new Label();
            labelByUser = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 9;
            // 
            // lblCodigoRastreo
            // 
            lblCodigoRastreo.AutoSize = true;
            lblCodigoRastreo.Location = new Point(12, 164);
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 238);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 15;
            label2.Text = "Lista de Clientes:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 334);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 28);
            comboBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 17;
            label3.Text = "Lista de Proveedores:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 376);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 19;
            label4.Text = "Peso (KG):";
            // 
            // FrmRecepcionPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(labelByUser);
            Controls.Add(labelWelcome);
            Controls.Add(label1);
            Controls.Add(lblCodigoRastreo);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label lblCodigoRastreo;
        private Label label1;
        private Label labelWelcome;
        private Label labelByUser;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}