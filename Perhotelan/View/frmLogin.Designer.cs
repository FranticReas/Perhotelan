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
            txtLoginEmail.Location = new Point(107, 300);
            txtLoginEmail.Margin = new Padding(4, 5, 4, 5);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Masukkan Email Anda Disini";
            txtLoginEmail.Size = new Size(314, 31);
            txtLoginEmail.TabIndex = 2;
            txtLoginEmail.TextChanged += txtLoginEmail_TextChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(107, 380);
            txtLoginPass.Margin = new Padding(4, 5, 4, 5);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PlaceholderText = "Masukkan Password Anda Disini";
            txtLoginPass.Size = new Size(281, 31);
            txtLoginPass.TabIndex = 3;
            txtLoginPass.TextChanged += txtLoginPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 199, 131);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(17, 70, 60);
            btnLogin.Location = new Point(107, 503);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(316, 85);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.ForeColor = SystemColors.ControlLightLight;
            lblregister.Location = new Point(160, 687);
            lblregister.Margin = new Padding(4, 0, 4, 0);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(166, 25);
            lblregister.TabIndex = 5;
            lblregister.Text = "Belum punya akun?";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(107, 270);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 22);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(107, 350);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 22);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.White;
            lnkRegister.Location = new Point(314, 687);
            lnkRegister.Margin = new Padding(4, 0, 4, 0);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(61, 25);
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
            lblHotel.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(81, 95);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(251, 73);
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
            lblKu.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(327, 95);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(123, 73);
            lblKu.TabIndex = 11;
            lblKu.Text = "KU";
            lblKu.Click += lblKu_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(387, 378);
            btnShowPass.Margin = new Padding(4, 5, 4, 5);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(36, 38);
            btnShowPass.TabIndex = 12;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // lnkLupa
            // 
            lnkLupa.AutoSize = true;
            lnkLupa.LinkColor = Color.White;
            lnkLupa.Location = new Point(107, 430);
            lnkLupa.Margin = new Padding(4, 0, 4, 0);
            lnkLupa.Name = "lnkLupa";
            lnkLupa.Size = new Size(112, 25);
            lnkLupa.TabIndex = 13;
            lnkLupa.TabStop = true;
            lnkLupa.Text = "Lupa Sandi ?";
            lnkLupa.LinkClicked += lnkLupa_LinkClicked;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(556, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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
