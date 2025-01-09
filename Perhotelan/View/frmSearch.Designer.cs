namespace Perhotelan.View
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            pnlHeader = new Panel();
            btnFilter = new Button();
            txtSearch = new TextBox();
            pnlSideBar = new Panel();
            btnHome = new Button();
            btnBooking = new Button();
            btnProfil = new Button();
            btnSearch = new Button();
            flpMenu = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(btnFilter);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(445, 45);
            pnlHeader.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.Location = new Point(393, 8);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(40, 27);
            btnFilter.TabIndex = 0;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 8);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Cari";
            txtSearch.Size = new Size(371, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
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
            pnlSideBar.TabIndex = 6;
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
            btnHome.Click += btnHome_Click;
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
            btnBooking.Click += btnBooking_Click;
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
            btnSearch.ForeColor = Color.FromArgb(250, 199, 131);
            btnSearch.Location = new Point(261, 4);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 53);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.Location = new Point(0, 43);
            flpMenu.Margin = new Padding(3, 4, 3, 4);
            flpMenu.Name = "flpMenu";
            flpMenu.Padding = new Padding(11, 33, 11, 13);
            flpMenu.Size = new Size(445, 492);
            flpMenu.TabIndex = 7;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 600);
            ControlBox = false;
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
            Controls.Add(flpMenu);
            Name = "frmSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelKu";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TextBox txtSearch;
        private Panel pnlSideBar;
        private Button btnHome;
        private Button btnBooking;
        private Button btnProfil;
        private Button btnSearch;
        private FlowLayoutPanel flpMenu;
        private Button btnFilter;
    }
}