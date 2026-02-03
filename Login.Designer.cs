namespace RepromosRA
{
    partial class Login
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
            linkLblRegister = new LinkLabel();
            lblUser = new Label();
            TxtUser = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pBxLogo = new PictureBox();
            btnLogin = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 43);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 0;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // linkLblRegister
            // 
            linkLblRegister.AutoSize = true;
            linkLblRegister.Location = new Point(245, 350);
            linkLblRegister.Name = "linkLblRegister";
            linkLblRegister.Size = new Size(251, 20);
            linkLblRegister.TabIndex = 1;
            linkLblRegister.TabStop = true;
            linkLblRegister.Text = "* Register User if you don't have user";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(261, 119);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "USER:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(261, 142);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(198, 27);
            TxtUser.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(261, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 5;
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(592, 12);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 6;
            pBxLogo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(261, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 30);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(366, 298);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 30);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(pBxLogo);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(TxtUser);
            Controls.Add(lblUser);
            Controls.Add(linkLblRegister);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLblRegister;
        private Label lblUser;
        private TextBox TxtUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private PictureBox pBxLogo;
        private Button btnLogin;
        private Button btnExit;
    }
}
