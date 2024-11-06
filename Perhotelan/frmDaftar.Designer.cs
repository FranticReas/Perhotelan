namespace Perhotelan
{
    partial class frmDaftar
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
            lblDaftar = new Label();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtTglLahir = new TextBox();
            txtNohp = new TextBox();
            txtPassConfrm = new TextBox();
            txtPass = new TextBox();
            btnDaftar = new Button();
            btnShowPass = new Button();
            btnShowPassConfrm = new Button();
            lblLogin = new Label();
            lnkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaftar.Location = new Point(165, 24);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(68, 25);
            lblDaftar.TabIndex = 0;
            lblDaftar.Text = "Daftar";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(24, 65);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(342, 23);
            txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(342, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(24, 141);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.PlaceholderText = "HH/BB/TTTT";
            txtTglLahir.Size = new Size(342, 23);
            txtTglLahir.TabIndex = 3;
            txtTglLahir.Leave += TxtTglLahir_Leave;
            // 
            // txtNohp
            // 
            txtNohp.Location = new Point(24, 180);
            txtNohp.Name = "txtNohp";
            txtNohp.PlaceholderText = "Nomor HP";
            txtNohp.Size = new Size(342, 23);
            txtNohp.TabIndex = 4;
            // 
            // txtPassConfrm
            // 
            txtPassConfrm.Location = new Point(24, 257);
            txtPassConfrm.Name = "txtPassConfrm";
            txtPassConfrm.PlaceholderText = "Konfirmasi Password";
            txtPassConfrm.Size = new Size(317, 23);
            txtPassConfrm.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(24, 218);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(317, 23);
            txtPass.TabIndex = 7;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(24, 305);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(342, 51);
            btnDaftar.TabIndex = 8;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(341, 218);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(25, 23);
            btnShowPass.TabIndex = 9;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnShowPassConfrm
            // 
            btnShowPassConfrm.Location = new Point(341, 257);
            btnShowPassConfrm.Name = "btnShowPassConfrm";
            btnShowPassConfrm.Size = new Size(25, 23);
            btnShowPassConfrm.TabIndex = 10;
            btnShowPassConfrm.Text = "👁";
            btnShowPassConfrm.UseVisualStyleBackColor = true;
            btnShowPassConfrm.Click += btnShowPassConfrm_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(99, 400);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(110, 15);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Sudah punya akun?";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(215, 400);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(37, 15);
            lnkLogin.TabIndex = 12;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // frmDaftar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(lnkLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnShowPassConfrm);
            Controls.Add(btnShowPass);
            Controls.Add(btnDaftar);
            Controls.Add(txtPass);
            Controls.Add(txtPassConfrm);
            Controls.Add(txtNohp);
            Controls.Add(txtTglLahir);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(lblDaftar);
            Name = "frmDaftar";
            Text = "HotelKu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDaftar;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtTglLahir;
        private TextBox txtNohp;
        private TextBox txtPassConfrm;
        private TextBox txtPass;
        private Button btnDaftar;
        private Button btnShowPass;
        private Button btnShowPassConfrm;
        private Label lblLogin;
        private LinkLabel lnkLogin;
    }
}