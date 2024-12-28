namespace Perhotelan
{
    partial class frmBooking
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
            pnlHeader = new Panel();
            txtSearch = new TextBox();
            flpBookings = new FlowLayoutPanel();
            btnOngoing = new Button();
            btnCompleted = new Button();
            btnCanceled = new Button();
            pnlSideBar.SuspendLayout();
            pnlHeader.SuspendLayout();
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
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(12, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(42, 40);
            btnHome.TabIndex = 4;
            btnHome.Text = "🏠";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBooking
            // 
            btnBooking.FlatAppearance.BorderColor = Color.White;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 12F);
            btnBooking.ForeColor = Color.FromArgb(250, 199, 131);
            btnBooking.Location = new Point(108, 3);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(42, 40);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "📖";
            btnBooking.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ControlLightLight;
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
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(389, 34);
            pnlHeader.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search";
            txtSearch.Size = new Size(365, 23);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpBookings
            // 
            flpBookings.AutoScroll = true;
            flpBookings.Location = new Point(0, 80);
            flpBookings.Name = "flpBookings";
            flpBookings.Size = new Size(389, 321);
            flpBookings.TabIndex = 7;
            flpBookings.Paint += flpBookings_Paint;
            // 
            // btnOngoing
            // 
            btnOngoing.Anchor = AnchorStyles.None;
            btnOngoing.BackColor = Color.FromArgb(17, 70, 60);
            btnOngoing.FlatAppearance.BorderSize = 0;
            btnOngoing.ForeColor = SystemColors.ControlLightLight;
            btnOngoing.Location = new Point(0, 38);
            btnOngoing.Name = "btnOngoing";
            btnOngoing.Size = new Size(115, 35);
            btnOngoing.TabIndex = 0;
            btnOngoing.Text = "Diproses";
            btnOngoing.UseVisualStyleBackColor = false;
            btnOngoing.Click += btnOngoing_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.Anchor = AnchorStyles.None;
            btnCompleted.Location = new Point(129, 39);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(115, 35);
            btnCompleted.TabIndex = 1;
            btnCompleted.Text = "Selesai";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnCanceled
            // 
            btnCanceled.Anchor = AnchorStyles.None;
            btnCanceled.Location = new Point(262, 40);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new Size(115, 35);
            btnCanceled.TabIndex = 2;
            btnCanceled.Text = "Dibatalkan";
            btnCanceled.UseVisualStyleBackColor = true;
            btnCanceled.Click += btnCanceled_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            ControlBox = false;
            Controls.Add(btnCanceled);
            Controls.Add(btnCompleted);
            Controls.Add(btnOngoing);
            Controls.Add(flpBookings);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
            Name = "frmBooking";
            Text = "Hotelku";
            pnlSideBar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Button btnHome;
        private Button btnBooking;
        private Button btnProfil;
        private Button btnSearch;
        private Panel pnlHeader;
        private TextBox txtSearch;
        private FlowLayoutPanel flpBookings;
        private Button btnOngoing;
        private Button btnCompleted;
        private Button btnCanceled;
    }
}