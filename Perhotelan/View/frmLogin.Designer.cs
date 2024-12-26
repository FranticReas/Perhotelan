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
            SuspendLayout();
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(75, 180);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Masukkan Email Anda Disini";
            txtLoginEmail.Size = new Size(221, 23);
            txtLoginEmail.TabIndex = 2;
            txtLoginEmail.TextChanged += txtLoginEmail_TextChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(75, 228);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PlaceholderText = "Masukkan Password Anda Disini";
            txtLoginPass.Size = new Size(198, 23);
            txtLoginPass.TabIndex = 3;
            txtLoginPass.TextChanged += txtLoginPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 199, 131);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(17, 70, 60);
            btnLogin.Location = new Point(27, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(328, 51);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.ForeColor = SystemColors.ControlLightLight;
            lblregister.Location = new Point(112, 412);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(111, 15);
            lblregister.TabIndex = 5;
            lblregister.Text = "Belum punya akun?";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(75, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(75, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.White;
            lnkRegister.Location = new Point(220, 412);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(39, 15);
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
            lblHotel.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(57, 57);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(170, 51);
            lblHotel.TabIndex = 10;
            lblHotel.Text = "HOTEL";
            lblHotel.Click += lblHotel_Click;
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(222, 57);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(84, 51);
            lblKu.TabIndex = 11;
            lblKu.Text = "KU";
            lblKu.Click += lblKu_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(271, 227);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(25, 23);
            btnShowPass.TabIndex = 12;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(389, 450);
            ControlBox = false;
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
            Name = "frmLogin";
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
    }
}
