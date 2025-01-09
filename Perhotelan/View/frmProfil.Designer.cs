namespace Perhotelan.View
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
            pnlHeader = new Panel();
            lblHotel = new Label();
            lblKu = new Label();
            btnProfilUpdate = new Button();
            btnBooking2 = new Button();
            btnPrivacy = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblPhoneNumber = new Label();
            lblName = new Label();
            lblEmail = new Label();
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
            pnlSideBar.Location = new Point(0, 539);
            pnlSideBar.Margin = new Padding(3, 0, 3, 4);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(445, 61);
            pnlSideBar.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(14, 4);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(48, 53);
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
            btnBooking.Location = new Point(123, 4);
            btnBooking.Margin = new Padding(3, 4, 3, 4);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(48, 53);
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
            btnProfil.Location = new Point(383, 4);
            btnProfil.Margin = new Padding(3, 4, 3, 4);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(48, 53);
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
            btnSearch.Location = new Point(261, 4);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 53);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // pbProfile
            // 
            pbProfile.Location = new Point(56, 112);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(125, 61);
            pbProfile.TabIndex = 3;
            pbProfile.TabStop = false;
            pbProfile.Visible = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(lblHotel);
            pnlHeader.Controls.Add(lblKu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(445, 85);
            pnlHeader.TabIndex = 8;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.FlatStyle = FlatStyle.Flat;
            lblHotel.Font = new Font("Montserrat Black", 32F, FontStyle.Bold);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(66, 0);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(227, 84);
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
            lblKu.Location = new Point(276, 0);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(117, 84);
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
            btnProfilUpdate.Location = new Point(82, 219);
            btnProfilUpdate.Name = "btnProfilUpdate";
            btnProfilUpdate.Size = new Size(327, 48);
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
            btnBooking2.Location = new Point(82, 268);
            btnBooking2.Name = "btnBooking2";
            btnBooking2.Size = new Size(327, 48);
            btnBooking2.TabIndex = 10;
            btnBooking2.Text = "Reservasi";
            btnBooking2.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking2.UseVisualStyleBackColor = false;
            btnBooking2.Click += btnBooking2_Click;
            // 
            // btnPrivacy
            // 
            btnPrivacy.Cursor = Cursors.Hand;
            btnPrivacy.FlatAppearance.BorderSize = 0;
            btnPrivacy.FlatStyle = FlatStyle.Flat;
            btnPrivacy.Font = new Font("Montserrat", 10.2F, FontStyle.Bold);
            btnPrivacy.ForeColor = Color.FromArgb(17, 70, 60);
            btnPrivacy.Location = new Point(82, 318);
            btnPrivacy.Name = "btnPrivacy";
            btnPrivacy.Size = new Size(327, 48);
            btnPrivacy.TabIndex = 12;
            btnPrivacy.Text = "Kebijakan Privasi";
            btnPrivacy.TextAlign = ContentAlignment.MiddleLeft;
            btnPrivacy.UseVisualStyleBackColor = true;
            btnPrivacy.Click += btnPrivacy_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(17, 70, 60);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(97, 463);
            button5.Name = "button5";
            button5.Size = new Size(233, 48);
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
            label1.Location = new Point(38, 225);
            label1.Name = "label1";
            label1.Size = new Size(47, 32);
            label1.TabIndex = 14;
            label1.Text = "🙍";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(17, 70, 60);
            label2.Location = new Point(38, 275);
            label2.Name = "label2";
            label2.Size = new Size(47, 32);
            label2.TabIndex = 15;
            label2.Text = "📖";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(17, 70, 60);
            label4.Location = new Point(38, 323);
            label4.Name = "label4";
            label4.Size = new Size(47, 32);
            label4.TabIndex = 17;
            label4.Text = "🔒";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(3, 40);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(50, 20);
            lblPhoneNumber.TabIndex = 6;
            lblPhoneNumber.Text = "label3";
            lblPhoneNumber.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 4;
            lblName.Text = "label1";
            lblName.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "label2";
            lblEmail.Visible = false;
            lblEmail.Click += lblEmail_Click;
            // 
            // flpDetail
            // 
            flpDetail.Controls.Add(lblEmail);
            flpDetail.Controls.Add(lblName);
            flpDetail.Controls.Add(lblPhoneNumber);
            flpDetail.FlowDirection = FlowDirection.TopDown;
            flpDetail.Location = new Point(431, 112);
            flpDetail.Margin = new Padding(3, 4, 3, 4);
            flpDetail.Name = "flpDetail";
            flpDetail.Size = new Size(62, 77);
            flpDetail.TabIndex = 18;
            // 
            // frmProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 600);
            ControlBox = false;
            Controls.Add(flpDetail);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnPrivacy);
            Controls.Add(btnBooking2);
            Controls.Add(btnProfilUpdate);
            Controls.Add(pbProfile);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
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
        private Panel pnlHeader;
        private Label lblHotel;
        private Label lblKu;
        private Button btnProfilUpdate;
        private Button btnBooking2;
        private Button btnPrivacy;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label lblPhoneNumber;
        private Label lblName;
        private Label lblEmail;
        private FlowLayoutPanel flpDetail;
    }
}