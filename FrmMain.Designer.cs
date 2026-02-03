namespace RepromosRA
{
    partial class FrmMain
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
            labelByUser = new Label();
            labelWelcome = new Label();
            label1 = new Label();
            pBxLogo = new PictureBox();
            btnTrackingPaquetes = new Button();
            btnRecepcionPaquetes = new Button();
            btnCerrarSesión = new Button();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelByUser
            // 
            labelByUser.AutoSize = true;
            labelByUser.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelByUser.Location = new Point(409, 54);
            labelByUser.Name = "labelByUser";
            labelByUser.Size = new Size(27, 28);
            labelByUser.TabIndex = 31;
            labelByUser.Text = ".";
            labelByUser.Click += labelByUser_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(286, 54);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(117, 28);
            labelWelcome.TabIndex = 30;
            labelWelcome.Text = "Welcome";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 12);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 29;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(608, 12);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 28;
            pBxLogo.TabStop = false;
            // 
            // btnTrackingPaquetes
            // 
            btnTrackingPaquetes.Location = new Point(408, 195);
            btnTrackingPaquetes.Name = "btnTrackingPaquetes";
            btnTrackingPaquetes.Size = new Size(147, 43);
            btnTrackingPaquetes.TabIndex = 32;
            btnTrackingPaquetes.Text = "Tracking Paquetes";
            btnTrackingPaquetes.UseVisualStyleBackColor = true;
            btnTrackingPaquetes.Click += btnTrackingPaquetes_Click;
            // 
            // btnRecepcionPaquetes
            // 
            btnRecepcionPaquetes.Location = new Point(189, 195);
            btnRecepcionPaquetes.Name = "btnRecepcionPaquetes";
            btnRecepcionPaquetes.Size = new Size(157, 43);
            btnRecepcionPaquetes.TabIndex = 33;
            btnRecepcionPaquetes.Text = "Recepción Paquetes";
            btnRecepcionPaquetes.UseVisualStyleBackColor = true;
            btnRecepcionPaquetes.Click += btnRecepcionPaquetes_Click;
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.Location = new Point(302, 279);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(154, 51);
            btnCerrarSesión.TabIndex = 34;
            btnCerrarSesión.Text = "Cerrar Sesión";
            btnCerrarSesión.UseVisualStyleBackColor = true;
            btnCerrarSesión.Click += btnCerrarSesión_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesión);
            Controls.Add(btnRecepcionPaquetes);
            Controls.Add(btnTrackingPaquetes);
            Controls.Add(labelByUser);
            Controls.Add(labelWelcome);
            Controls.Add(label1);
            Controls.Add(pBxLogo);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelByUser;
        private Label labelWelcome;
        private Label label1;
        private PictureBox pBxLogo;
        private Button btnTrackingPaquetes;
        private Button btnRecepcionPaquetes;
        private Button btnCerrarSesión;
    }
}