﻿namespace Perhotelan.View
{
    partial class frmProfil
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
            pnlSideBar = new Panel();
            btnHome = new Button();
            btnBooking = new Button();
            btnProfil = new Button();
            btnSearch = new Button();
            pbProfile = new PictureBox();
            lblName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            pnlHeader = new Panel();
            lblHotel = new Label();
            lblKu = new Label();
            btnProfilUpdate = new Button();
            btnBooking2 = new Button();
            btnNotif = new Button();
            btnPrivacy = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flpDetail = new FlowLayoutPanel();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            pnlHeader.SuspendLayout();
            flpDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(17, 70, 60);
            pnlSideBar.Controls.Add(btnHome);
            pnlSideBar.Controls.Add(btnBooking);
            pnlSideBar.Controls.Add(btnProfil);
            pnlSideBar.Controls.Add(btnSearch);
            pnlSideBar.Dock = DockStyle.Bottom;
            pnlSideBar.Location = new Point(0, 404);
            pnlSideBar.Margin = new Padding(3, 0, 3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(389, 46);
            pnlSideBar.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(42, 40);
            btnHome.TabIndex = 4;
            btnHome.Text = "🏠";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click_1;
            // 
            // btnBooking
            // 
            btnBooking.FlatAppearance.BorderColor = Color.White;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 12F);
            btnBooking.ForeColor = SystemColors.ControlLightLight;
            btnBooking.Location = new Point(108, 3);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(42, 40);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "📖";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click_1;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.FromArgb(250, 199, 131);
            btnProfil.Location = new Point(335, 3);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(42, 40);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "🙍";
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(228, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // pbProfile
            // 
            pbProfile.Location = new Point(49, 84);
            pbProfile.Margin = new Padding(3, 2, 3, 2);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(109, 46);
            pbProfile.TabIndex = 3;
            pbProfile.TabStop = false;
            pbProfile.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 4;
            lblName.Text = "label1";
            lblName.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "label2";
            lblEmail.Visible = false;
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(3, 30);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(38, 15);
            lblPhoneNumber.TabIndex = 6;
            lblPhoneNumber.Text = "label3";
            lblPhoneNumber.Visible = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(lblHotel);
            pnlHeader.Controls.Add(lblKu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(389, 64);
            pnlHeader.TabIndex = 8;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.FlatStyle = FlatStyle.Flat;
            lblHotel.Font = new Font("Montserrat Black", 32F, FontStyle.Bold);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(58, 0);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(180, 60);
            lblHotel.TabIndex = 12;
            lblHotel.Text = "HOTEL";
            lblHotel.Click += lblHotel_Click;
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Montserrat Black", 32F, FontStyle.Bold);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(223, 0);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(92, 60);
            lblKu.TabIndex = 13;
            lblKu.Text = "KU";
            // 
            // btnProfilUpdate
            // 
            btnProfilUpdate.BackColor = Color.Transparent;
            btnProfilUpdate.Cursor = Cursors.Hand;
            btnProfilUpdate.FlatAppearance.BorderSize = 0;
            btnProfilUpdate.FlatStyle = FlatStyle.Flat;
            btnProfilUpdate.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfilUpdate.ForeColor = Color.FromArgb(17, 70, 60);
            btnProfilUpdate.Location = new Point(72, 164);
            btnProfilUpdate.Margin = new Padding(3, 2, 3, 2);
            btnProfilUpdate.Name = "btnProfilUpdate";
            btnProfilUpdate.Size = new Size(286, 36);
            btnProfilUpdate.TabIndex = 9;
            btnProfilUpdate.Text = "Profil Saya";
            btnProfilUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnProfilUpdate.UseVisualStyleBackColor = false;
            btnProfilUpdate.Click += btnProfilUpdate_Click;
            // 
            // btnBooking2
            // 
            btnBooking2.BackColor = Color.Transparent;
            btnBooking2.Cursor = Cursors.Hand;
            btnBooking2.FlatAppearance.BorderSize = 0;
            btnBooking2.FlatStyle = FlatStyle.Flat;
            btnBooking2.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnBooking2.ForeColor = Color.FromArgb(17, 70, 60);
            btnBooking2.Location = new Point(72, 201);
            btnBooking2.Margin = new Padding(3, 2, 3, 2);
            btnBooking2.Name = "btnBooking2";
            btnBooking2.Size = new Size(286, 36);
            btnBooking2.TabIndex = 10;
            btnBooking2.Text = "Reservasi";
            btnBooking2.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking2.UseVisualStyleBackColor = false;
            btnBooking2.Click += btnBooking2_Click;
            // 
            // btnNotif
            // 
            btnNotif.Cursor = Cursors.Hand;
            btnNotif.FlatAppearance.BorderSize = 0;
            btnNotif.FlatStyle = FlatStyle.Flat;
            btnNotif.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnNotif.ForeColor = Color.FromArgb(17, 70, 60);
            btnNotif.Location = new Point(72, 241);
            btnNotif.Margin = new Padding(3, 2, 3, 2);
            btnNotif.Name = "btnNotif";
            btnNotif.Size = new Size(286, 36);
            btnNotif.TabIndex = 11;
            btnNotif.Text = "Notifikasi";
            btnNotif.TextAlign = ContentAlignment.MiddleLeft;
            btnNotif.UseVisualStyleBackColor = true;
            // 
            // btnPrivacy
            // 
            btnPrivacy.Cursor = Cursors.Hand;
            btnPrivacy.FlatAppearance.BorderSize = 0;
            btnPrivacy.FlatStyle = FlatStyle.Flat;
            btnPrivacy.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnPrivacy.ForeColor = Color.FromArgb(17, 70, 60);
            btnPrivacy.Location = new Point(72, 280);
            btnPrivacy.Margin = new Padding(3, 2, 3, 2);
            btnPrivacy.Name = "btnPrivacy";
            btnPrivacy.Size = new Size(286, 36);
            btnPrivacy.TabIndex = 12;
            btnPrivacy.Text = "Kebijakan Privasi";
            btnPrivacy.TextAlign = ContentAlignment.MiddleLeft;
            btnPrivacy.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(17, 70, 60);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(85, 347);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(204, 36);
            button5.TabIndex = 13;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(17, 70, 60);
            label1.Location = new Point(33, 169);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 14;
            label1.Text = "🙍";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(17, 70, 60);
            label2.Location = new Point(33, 206);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 15;
            label2.Text = "📖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(17, 70, 60);
            label3.Location = new Point(33, 246);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 16;
            label3.Text = "🔔";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(17, 70, 60);
            label4.Location = new Point(33, 285);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 17;
            label4.Text = "🔒";
            // 
            // flpDetail
            // 
            flpDetail.Controls.Add(lblEmail);
            flpDetail.Controls.Add(lblName);
            flpDetail.Controls.Add(lblPhoneNumber);
            flpDetail.FlowDirection = FlowDirection.TopDown;
            flpDetail.Location = new Point(185, 80);
            flpDetail.Name = "flpDetail";
            flpDetail.Size = new Size(204, 58);
            flpDetail.TabIndex = 18;
            // 
            // frmProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            ControlBox = false;
            Controls.Add(flpDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnPrivacy);
            Controls.Add(btnNotif);
            Controls.Add(btnBooking2);
            Controls.Add(btnProfilUpdate);
            Controls.Add(pbProfile);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProfil";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelKu";
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpDetail.ResumeLayout(false);
            flpDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideBar;
        private Button btnHome;
        private Button btnBooking;
        private Button btnProfil;
        private Button btnSearch;
        private PictureBox pbProfile;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Panel pnlHeader;
        private Label lblHotel;
        private Label lblKu;
        private Button btnProfilUpdate;
        private Button btnBooking2;
        private Button btnNotif;
        private Button btnPrivacy;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flpDetail;
    }
}