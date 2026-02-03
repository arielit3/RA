namespace RepromosRA
{
    partial class RegisterUser
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
            label1 = new Label();
            label2 = new Label();
            pBxLogo = new PictureBox();
            lblFullName = new Label();
            ROL = new Label();
            txtBxFullName = new TextBox();
            btnReturn = new Button();
            txtBxUser = new TextBox();
            label3 = new Label();
            txtBxPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBxConfirmPass = new TextBox();
            btnRegisterUser = new Button();
            comboBxROL = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pBxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 1;
            label1.Text = " Aragorn S.L. Logistic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 58);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 2;
            label2.Text = "Register Users";
            // 
            // pBxLogo
            // 
            pBxLogo.BackgroundImageLayout = ImageLayout.Center;
            pBxLogo.Image = Properties.Resources.Uni_logo;
            pBxLogo.Location = new Point(377, 29);
            pBxLogo.Name = "pBxLogo";
            pBxLogo.Size = new Size(180, 81);
            pBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBxLogo.TabIndex = 7;
            pBxLogo.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(97, 123);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(89, 20);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "FULL NAME:";
            // 
            // ROL
            // 
            ROL.AutoSize = true;
            ROL.Location = new Point(97, 179);
            ROL.Name = "ROL";
            ROL.Size = new Size(39, 20);
            ROL.TabIndex = 9;
            ROL.Text = "ROL:";
            // 
            // txtBxFullName
            // 
            txtBxFullName.Location = new Point(97, 146);
            txtBxFullName.Name = "txtBxFullName";
            txtBxFullName.Size = new Size(224, 27);
            txtBxFullName.TabIndex = 10;
            txtBxFullName.TextChanged += txtBxFullName_TextChanged;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(463, 435);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtBxUser
            // 
            txtBxUser.Location = new Point(97, 255);
            txtBxUser.Name = "txtBxUser";
            txtBxUser.Size = new Size(224, 27);
            txtBxUser.TabIndex = 14;
            txtBxUser.TextChanged += txtBxUser_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 232);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 13;
            label3.Text = "USER:";
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(97, 311);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(224, 27);
            txtBxPassword.TabIndex = 16;
            txtBxPassword.TextChanged += txtBxPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 288);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 15;
            label4.Text = "PASSWORD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 341);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 17;
            label5.Text = "CONFIRM PASSWORD:";
            label5.Click += label5_Click;
            // 
            // txtBxConfirmPass
            // 
            txtBxConfirmPass.Location = new Point(97, 364);
            txtBxConfirmPass.Name = "txtBxConfirmPass";
            txtBxConfirmPass.Size = new Size(224, 27);
            txtBxConfirmPass.TabIndex = 18;
            txtBxConfirmPass.TextChanged += txtBxConfirmPass_TextChanged;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.BackColor = Color.Chartreuse;
            btnRegisterUser.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegisterUser.Location = new Point(160, 416);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(133, 29);
            btnRegisterUser.TabIndex = 19;
            btnRegisterUser.Text = "Register User";
            btnRegisterUser.UseVisualStyleBackColor = false;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // comboBxROL
            // 
            comboBxROL.FormattingEnabled = true;
            comboBxROL.Location = new Point(97, 201);
            comboBxROL.Name = "comboBxROL";
            comboBxROL.Size = new Size(224, 28);
            comboBxROL.TabIndex = 20;
            comboBxROL.SelectedIndexChanged += comboBxROL_SelectedIndexChanged;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 476);
            Controls.Add(comboBxROL);
            Controls.Add(btnRegisterUser);
            Controls.Add(txtBxConfirmPass);
            Controls.Add(label5);
            Controls.Add(txtBxPassword);
            Controls.Add(label4);
            Controls.Add(txtBxUser);
            Controls.Add(label3);
            Controls.Add(btnReturn);
            Controls.Add(txtBxFullName);
            Controls.Add(ROL);
            Controls.Add(lblFullName);
            Controls.Add(pBxLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterUser";
            Text = "RegisterUser";
            Load += RegisterUser_Load;
            ((System.ComponentModel.ISupportInitialize)pBxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pBxLogo;
        private Label lblFullName;
        private Label ROL;
        private TextBox txtBxFullName;
        private Button btnReturn;
        private TextBox txtBxUser;
        private Label label3;
        private TextBox txtBxPassword;
        private Label label4;
        private Label label5;
        private TextBox txtBxConfirmPass;
        private Button btnRegisterUser;
        private ComboBox comboBxROL;
    }
}