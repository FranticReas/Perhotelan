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
            lblHotel = new Label();
            lblKu = new Label();
            btnShowPass = new Button();
            lnkLupa = new LinkLabel();
            SuspendLayout();
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Anchor = AnchorStyles.None;
            txtLoginEmail.Location = new Point(86, 240);
            txtLoginEmail.Margin = new Padding(3, 4, 3, 4);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Masukkan Email Anda Disini";
            txtLoginEmail.Size = new Size(252, 27);
            txtLoginEmail.TabIndex = 2;
            txtLoginEmail.TextChanged += txtLoginEmail_TextChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(86, 304);
            txtLoginPass.Margin = new Padding(3, 4, 3, 4);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PlaceholderText = "Masukkan Password Anda Disini";
            txtLoginPass.Size = new Size(226, 27);
            txtLoginPass.TabIndex = 3;
            txtLoginPass.TextChanged += txtLoginPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 199, 131);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(17, 70, 60);
            btnLogin.Location = new Point(86, 402);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 68);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.ForeColor = SystemColors.ControlLightLight;
            lblregister.Location = new Point(108, 550);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(137, 20);
            lblregister.TabIndex = 5;
            lblregister.Text = "Belum punya akun?";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(82, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 24);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(82, 279);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 24);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.White;
            lnkRegister.Location = new Point(241, 550);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(51, 20);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Daftar";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.FlatStyle = FlatStyle.Flat;
            lblHotel.Font = new Font("Montserrat Black", 31.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(65, 76);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(223, 73);
            lblHotel.TabIndex = 10;
            lblHotel.Text = "HOTEL";
            lblHotel.Click += lblHotel_Click;
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.FlatStyle = FlatStyle.Flat;
            lblKu.Font = new Font("Montserrat Black", 31.8F, FontStyle.Bold);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(261, 76);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(114, 73);
            lblKu.TabIndex = 11;
            lblKu.Text = "KU";
            lblKu.Click += lblKu_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(310, 302);
            btnShowPass.Margin = new Padding(3, 4, 3, 4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(29, 30);
            btnShowPass.TabIndex = 12;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // lnkLupa
            // 
            lnkLupa.AutoSize = true;
            lnkLupa.LinkColor = Color.White;
            lnkLupa.Location = new Point(86, 344);
            lnkLupa.Name = "lnkLupa";
            lnkLupa.Size = new Size(93, 20);
            lnkLupa.TabIndex = 13;
            lnkLupa.TabStop = true;
            lnkLupa.Text = "Lupa Sandi ?";
            lnkLupa.LinkClicked += lnkLupa_LinkClicked;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(445, 600);
            ControlBox = false;
            Controls.Add(lnkLupa);
            Controls.Add(btnShowPass);
            Controls.Add(lblHotel);
            Controls.Add(lblKu);
            Controls.Add(lnkRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblregister);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginPass);
            Controls.Add(txtLoginEmail);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelKu";
            Load += frmLogin_Load;
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
        private Label lblHotel;
        private Label lblKu;
        private Button btnShowPass;
        private LinkLabel lnkLupa;
    }
}
