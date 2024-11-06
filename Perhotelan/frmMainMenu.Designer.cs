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
            btnSidePanel = new Button();
            pnlSideBar = new Panel();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lblProfile2 = new Label();
            lblProfile = new Label();
            btnProfile = new Button();
            btnSearch = new Button();
            flpMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pnlSideBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSidePanel
            // 
            btnSidePanel.Dock = DockStyle.Left;
            btnSidePanel.FlatAppearance.BorderColor = Color.White;
            btnSidePanel.FlatAppearance.BorderSize = 0;
            btnSidePanel.FlatStyle = FlatStyle.Flat;
            btnSidePanel.Location = new Point(0, 0);
            btnSidePanel.Name = "btnSidePanel";
            btnSidePanel.Size = new Size(36, 34);
            btnSidePanel.TabIndex = 0;
            btnSidePanel.Text = "⋮";
            btnSidePanel.UseVisualStyleBackColor = true;
            btnSidePanel.Click += btnSidePanel_Click;
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(label3);
            pnlSideBar.Controls.Add(label4);
            pnlSideBar.Controls.Add(button2);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(label2);
            pnlSideBar.Controls.Add(button1);
            pnlSideBar.Controls.Add(lblProfile2);
            pnlSideBar.Controls.Add(lblProfile);
            pnlSideBar.Controls.Add(btnProfile);
            pnlSideBar.Location = new Point(0, 26);
            pnlSideBar.Margin = new Padding(3, 0, 3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(210, 431);
            pnlSideBar.TabIndex = 1;
            pnlSideBar.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 8;
            label3.Text = "🔔";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(176, 108);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 7;
            label4.Text = ">";
            // 
            // button2
            // 
            button2.Location = new Point(4, 98);
            button2.Name = "button2";
            button2.Size = new Size(201, 35);
            button2.TabIndex = 6;
            button2.Text = "Notifikasi";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 5;
            label1.Text = "📚";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(176, 67);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 4;
            label2.Text = ">";
            // 
            // button1
            // 
            button1.Location = new Point(4, 57);
            button1.Name = "button1";
            button1.Size = new Size(201, 35);
            button1.TabIndex = 3;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblProfile2
            // 
            lblProfile2.AutoSize = true;
            lblProfile2.BackColor = Color.White;
            lblProfile2.FlatStyle = FlatStyle.Flat;
            lblProfile2.Font = new Font("Segoe UI", 12F);
            lblProfile2.Location = new Point(12, 21);
            lblProfile2.Name = "lblProfile2";
            lblProfile2.Size = new Size(32, 21);
            lblProfile2.TabIndex = 2;
            lblProfile2.Text = "🙍";
            lblProfile2.Click += lblProfile2_Click;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.BackColor = Color.White;
            lblProfile.FlatStyle = FlatStyle.Flat;
            lblProfile.Font = new Font("Segoe UI", 9F);
            lblProfile.Location = new Point(176, 26);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(15, 15);
            lblProfile.TabIndex = 1;
            lblProfile.Text = ">";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(4, 16);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(201, 35);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profilku";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(353, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(36, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.Location = new Point(0, 0);
            flpMenu.Name = "flpMenu";
            flpMenu.Padding = new Padding(10, 25, 10, 10);
            flpMenu.Size = new Size(389, 450);
            flpMenu.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnSidePanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 34);
            panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(36, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 23);
            txtSearch.TabIndex = 6;
            txtSearch.Visible = false;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(panel1);
            Controls.Add(pnlSideBar);
            Controls.Add(flpMenu);
            Name = "frmMainMenu";
            Text = "HotelKu";
            Load += frmMainMenu_Load;
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSidePanel;
        private Panel pnlSideBar;
        private Label lblProfile;
        private Button btnProfile;
        private Label lblProfile2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button btnSearch;
        private FlowLayoutPanel flpMenu;
        private Panel panel1;
        private TextBox txtSearch;
    }
}