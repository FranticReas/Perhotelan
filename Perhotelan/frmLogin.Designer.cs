namespace Perhotelan
{
    partial class frmLogin
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
            txtLoginEmail = new TextBox();
            txtLoginPass = new TextBox();
            btnLogin = new Button();
            lblregister = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lnkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(76, 192);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(221, 23);
            txtLoginEmail.TabIndex = 2;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(76, 240);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(221, 23);
            txtLoginPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(27, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(328, 51);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.Location = new Point(93, 409);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(111, 15);
            lblregister.TabIndex = 5;
            lblregister.Text = "Belum punya akun?";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(76, 222);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(210, 409);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(39, 15);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Daftar";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(lnkRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblregister);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPass);
            Controls.Add(txtLoginEmail);
            Name = "frmLogin";
            Text = "HotelKu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginEmail;
        private TextBox txtLoginPass;
        private Button btnLogin;
        private Label lblregister;
        private Label lblEmail;
        private Label lblPassword;
        private LinkLabel lnkRegister;
    }
}
