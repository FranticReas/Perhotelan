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
            flpBookings.SuspendLayout();
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
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(14, 4);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(48, 53);
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
            btnBooking.Location = new Point(123, 4);
            btnBooking.Margin = new Padding(3, 4, 3, 4);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(48, 53);
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
            btnProfil.Location = new Point(383, 4);
            btnProfil.Margin = new Padding(3, 4, 3, 4);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(48, 53);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "🙍";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(445, 45);
            pnlHeader.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 8);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search";
            txtSearch.Size = new Size(417, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpBookings
            // 
            flpBookings.AutoScroll = true;
            flpBookings.Controls.Add(btnOngoing);
            flpBookings.Controls.Add(btnCompleted);
            flpBookings.Controls.Add(btnCanceled);
            flpBookings.Location = new Point(0, 52);
            flpBookings.Margin = new Padding(3, 4, 3, 4);
            flpBookings.Name = "flpBookings";
            flpBookings.Size = new Size(445, 483);
            flpBookings.TabIndex = 7;
            flpBookings.Paint += flpBookings_Paint;
            // 
            // btnOngoing
            // 
            btnOngoing.Anchor = AnchorStyles.None;
            btnOngoing.BackColor = Color.FromArgb(17, 70, 60);
            btnOngoing.FlatAppearance.BorderSize = 0;
            btnOngoing.ForeColor = SystemColors.ControlLightLight;
            btnOngoing.Location = new Point(3, 4);
            btnOngoing.Margin = new Padding(3, 4, 3, 4);
            btnOngoing.Name = "btnOngoing";
            btnOngoing.Size = new Size(131, 47);
            btnOngoing.TabIndex = 0;
            btnOngoing.Text = "Diproses";
            btnOngoing.UseVisualStyleBackColor = false;
            btnOngoing.Click += btnOngoing_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.Anchor = AnchorStyles.None;
            btnCompleted.Location = new Point(140, 4);
            btnCompleted.Margin = new Padding(3, 4, 3, 4);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(131, 47);
            btnCompleted.TabIndex = 1;
            btnCompleted.Text = "Selesai";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnCanceled
            // 
            btnCanceled.Anchor = AnchorStyles.None;
            btnCanceled.Location = new Point(277, 4);
            btnCanceled.Margin = new Padding(3, 4, 3, 4);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new Size(131, 47);
            btnCanceled.TabIndex = 2;
            btnCanceled.Text = "Dibatalkan";
            btnCanceled.UseVisualStyleBackColor = true;
            btnCanceled.Click += btnCanceled_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 600);
            ControlBox = false;
            Controls.Add(flpBookings);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotelku";
            pnlSideBar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            flpBookings.ResumeLayout(false);
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