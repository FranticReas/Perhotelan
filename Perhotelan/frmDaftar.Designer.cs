﻿namespace Perhotelan
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
            txtNama.Font = new Font("Montserrat", 9F);
            txtNama.Location = new Point(26, 89);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama";
            txtNama.Size = new Size(342, 22);
            txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Montserrat", 9F);
            txtEmail.Location = new Point(26, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(342, 22);
            txtEmail.TabIndex = 2;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Font = new Font("Montserrat", 9F);
            txtTglLahir.Location = new Point(26, 165);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.PlaceholderText = "HH/BB/TTTT";
            txtTglLahir.Size = new Size(342, 22);
            txtTglLahir.TabIndex = 3;
            txtTglLahir.Leave += TxtTglLahir_Leave;
            // 
            // txtNohp
            // 
            txtNohp.Font = new Font("Montserrat", 9F);
            txtNohp.Location = new Point(26, 204);
            txtNohp.Name = "txtNohp";
            txtNohp.PlaceholderText = "Nomor HP";
            txtNohp.Size = new Size(342, 22);
            txtNohp.TabIndex = 4;
            // 
            // txtPassConfrm
            // 
            txtPassConfrm.Font = new Font("Montserrat", 9F);
            txtPassConfrm.Location = new Point(26, 281);
            txtPassConfrm.Name = "txtPassConfrm";
            txtPassConfrm.PlaceholderText = "Konfirmasi Password";
            txtPassConfrm.Size = new Size(317, 22);
            txtPassConfrm.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Montserrat", 9F);
            txtPass.Location = new Point(26, 242);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(317, 22);
            txtPass.TabIndex = 7;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(250, 199, 131);
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.FromArgb(17, 70, 60);
            btnDaftar.Location = new Point(26, 329);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(342, 51);
            btnDaftar.TabIndex = 8;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Location = new Point(343, 242);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(25, 23);
            btnShowPass.TabIndex = 9;
            btnShowPass.Text = "👁";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnShowPassConfrm
            // 
            btnShowPassConfrm.Location = new Point(343, 281);
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
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(108, 412);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(110, 15);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Sudah punya akun?";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = Color.White;
            lnkLogin.Location = new Point(224, 412);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(37, 15);
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
            lblHotel.Font = new Font("Montserrat Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(61, 9);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(180, 60);
            lblHotel.TabIndex = 13;
            lblHotel.Text = "HOTEL";
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Montserrat Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(235, 9);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(92, 60);
            lblKu.TabIndex = 14;
            lblKu.Text = "KU";
            // 
            // frmDaftar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(389, 450);
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