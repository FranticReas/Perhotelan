namespace Perhotelan
{
    partial class frmMainMenu
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
            btnRooms = new Button();
            btnProfil = new Button();
            btnSearch = new Button();
            flpMenu = new FlowLayoutPanel();
            pnlHeader = new Panel();
            txtSearch = new TextBox();
            pnlSideBar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.PaleGreen;
            pnlSideBar.Controls.Add(btnHome);
            pnlSideBar.Controls.Add(btnRooms);
            pnlSideBar.Controls.Add(btnProfil);
            pnlSideBar.Controls.Add(btnSearch);
            pnlSideBar.Dock = DockStyle.Bottom;
            pnlSideBar.Location = new Point(0, 404);
            pnlSideBar.Margin = new Padding(3, 0, 3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(389, 46);
            pnlSideBar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.Location = new Point(12, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(42, 40);
            btnHome.TabIndex = 4;
            btnHome.Text = "🏠";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderColor = Color.White;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 12F);
            btnRooms.Location = new Point(108, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(42, 40);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "🏢";
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnSearch.Location = new Point(228, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.Location = new Point(0, 32);
            flpMenu.Name = "flpMenu";
            flpMenu.Padding = new Padding(10, 25, 10, 10);
            flpMenu.Size = new Size(389, 369);
            flpMenu.TabIndex = 4;
            flpMenu.Paint += flpMenu_Paint;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightGreen;
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(389, 34);
            pnlHeader.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(365, 23);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSideBar);
            Controls.Add(flpMenu);
            Name = "frmMainMenu";
            Text = "HotelKu";
            Load += frmMainMenu_Load;
            pnlSideBar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSideBar;
        private Button btnSearch;
        private FlowLayoutPanel flpMenu;
        private Panel pnlHeader;
        private Button btnProfil;
        private Button btnHome;
        private Button btnRooms;
        private TextBox textBox1;
        private TextBox txtSearch;
    }
}