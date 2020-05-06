namespace Orarend_WPF
{
    partial class frmLogin
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
            this.btBelepes = new System.Windows.Forms.Button();
            this.lblogin = new System.Windows.Forms.Label();
            this.btKilepgomb = new System.Windows.Forms.Button();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBelepes
            // 
            this.btBelepes.Location = new System.Drawing.Point(155, 154);
            this.btBelepes.Margin = new System.Windows.Forms.Padding(2);
            this.btBelepes.Name = "btBelepes";
            this.btBelepes.Size = new System.Drawing.Size(60, 24);
            this.btBelepes.TabIndex = 0;
            this.btBelepes.Text = "Belépés";
            this.btBelepes.UseVisualStyleBackColor = true;
            this.btBelepes.Click += new System.EventHandler(this.btBelepes_Click);
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblogin.Location = new System.Drawing.Point(117, 30);
            this.lblogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(110, 17);
            this.lblogin.TabIndex = 1;
            this.lblogin.Text = "Felhasználónév";
            // 
            // btKilepgomb
            // 
            this.btKilepgomb.Location = new System.Drawing.Point(294, 154);
            this.btKilepgomb.Margin = new System.Windows.Forms.Padding(2);
            this.btKilepgomb.Name = "btKilepgomb";
            this.btKilepgomb.Size = new System.Drawing.Size(60, 24);
            this.btKilepgomb.TabIndex = 2;
            this.btKilepgomb.Text = "Kilép";
            this.btKilepgomb.UseVisualStyleBackColor = true;
            this.btKilepgomb.Click += new System.EventHandler(this.btKilepgomb_Click);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(145, 93);
            this.lbpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(47, 17);
            this.lbpassword.TabIndex = 3;
            this.lbpassword.Text = "Jelszó";
            // 
            // txUsername
            // 
            this.txUsername.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.Location = new System.Drawing.Point(227, 28);
            this.txUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(164, 24);
            this.txUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(227, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(164, 24);
            this.txtPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 108);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 206);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.btKilepgomb);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.btBelepes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBelepes;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Button btKilepgomb;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}