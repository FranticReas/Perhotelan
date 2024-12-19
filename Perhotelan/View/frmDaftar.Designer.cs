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
            lblHotel = new Label();
            lblKu = new Label();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Microsoft Sans Serif", 9F);
            txtNama.Location = new Point(30, 119);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(390, 24);
            txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.Location = new Point(30, 169);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(390, 24);
            txtEmail.TabIndex = 2;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Font = new Font("Microsoft Sans Serif", 9F);
            txtTglLahir.Location = new Point(30, 220);
            txtTglLahir.Margin = new Padding(3, 4, 3, 4);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.PlaceholderText = "TTTT/BB/HH";
            txtTglLahir.Size = new Size(390, 24);
            txtTglLahir.TabIndex = 3;
            txtTglLahir.TextChanged += txtTglLahir_TextChanged;
            txtTglLahir.Leave += TxtTglLahir_Leave;
            // 
            // txtNohp
            // 
            txtNohp.Font = new Font("Microsoft Sans Serif", 9F);
            txtNohp.Location = new Point(30, 272);
            txtNohp.Margin = new Padding(3, 4, 3, 4);
            txtNohp.Name = "txtNohp";
            txtNohp.PlaceholderText = "Nomor HP";
            txtNohp.Size = new Size(390, 24);
            txtNohp.TabIndex = 4;
            txtNohp.TextChanged += txtNohp_TextChanged;
            // 
            // txtPassConfrm
            // 
            txtPassConfrm.Font = new Font("Microsoft Sans Serif", 9F);
            txtPassConfrm.Location = new Point(30, 375);
            txtPassConfrm.Margin = new Padding(3, 4, 3, 4);
            txtPassConfrm.Name = "txtPassConfrm";
            txtPassConfrm.PlaceholderText = "Konfirmasi Password";
            txtPassConfrm.Size = new Size(362, 24);
            txtPassConfrm.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 9F);
            txtPass.Location = new Point(30, 323);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(362, 24);
            txtPass.TabIndex = 7;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(250, 199, 131);
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.FromArgb(17, 70, 60);
            btnDaftar.Location = new Point(30, 439);
            btnDaftar.Margin = new Padding(3, 4, 3, 4);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(391, 68);
            btnDaftar.TabIndex = 8;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(392, 323);
            btnShowPass.Margin = new Padding(3, 4, 3, 4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(29, 31);
            btnShowPass.TabIndex = 9;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnShowPassConfrm
            // 
            btnShowPassConfrm.Location = new Point(392, 375);
            btnShowPassConfrm.Margin = new Padding(3, 4, 3, 4);
            btnShowPassConfrm.Name = "btnShowPassConfrm";
            btnShowPassConfrm.Size = new Size(29, 31);
            btnShowPassConfrm.TabIndex = 10;
            btnShowPassConfrm.Text = "👁";
            btnShowPassConfrm.UseVisualStyleBackColor = true;
            btnShowPassConfrm.Click += btnShowPassConfrm_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(123, 549);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(136, 20);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Sudah punya akun?";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = Color.White;
            lnkLogin.Location = new Point(256, 549);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(46, 20);
            lnkLogin.TabIndex = 12;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.FlatStyle = FlatStyle.Flat;
            lblHotel.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(70, 12);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(212, 63);
            lblHotel.TabIndex = 13;
            lblHotel.Text = "HOTEL";
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(269, 12);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(104, 63);
            lblKu.TabIndex = 14;
            lblKu.Text = "KU";
            // 
            // frmDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(445, 600);
            ControlBox = false;
            Controls.Add(lblHotel);
            Controls.Add(lblKu);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDaftar";
            Text = "HotelKu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label lblHotel;
        private Label lblKu;
    }
}