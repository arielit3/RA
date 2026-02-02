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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btn_regresar.Location = new Point(9, 510);
            btn_regresar.Margin = new Padding(0);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(146, 47);
            btn_regresar.TabIndex = 10;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 11;
            // 
            // fm_SPaquetes_General
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(927, 566);
            Controls.Add(dataGridView1);
            Controls.Add(btn_regresar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fm_SPaquetes_General";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fm_SPaquetes_General";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_regresar;
        private DataGridView dataGridView1;
    }
}