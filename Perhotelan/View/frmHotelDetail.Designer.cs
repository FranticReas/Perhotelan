namespace Perhotelan.View
{
    partial class frmHotelDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotelDesign));
            pnlHeader = new Panel();
            btnBack = new Button();
            lblHotel = new Label();
            lblKu = new Label();
            pcbHotel = new PictureBox();
            lblHotelName = new Label();
            pcbRating = new PictureBox();
            lblRating = new Label();
            lblReview = new Label();
            lblReview2 = new Label();
            lblLokasi = new Label();
            lblAvaibleRoom = new Label();
            flpRoom = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHotel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRating).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Controls.Add(lblHotel);
            pnlHeader.Controls.Add(lblKu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(345, 57);
            pnlHeader.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Montserrat Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(250, 199, 131);
            btnBack.Location = new Point(1, 0);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 57);
            btnBack.TabIndex = 17;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.FlatStyle = FlatStyle.Flat;
            lblHotel.Font = new Font("Montserrat Black", 24F, FontStyle.Bold);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(53, -1);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(171, 62);
            lblHotel.TabIndex = 15;
            lblHotel.Text = "HOTEL";
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Montserrat Black", 24F, FontStyle.Bold);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(207, 0);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(89, 62);
            lblKu.TabIndex = 16;
            lblKu.Text = "KU";
            // 
            // pcbHotel
            // 
            pcbHotel.Anchor = AnchorStyles.None;
            pcbHotel.BackgroundImageLayout = ImageLayout.None;
            pcbHotel.Image = (Image)resources.GetObject("pcbHotel.Image");
            pcbHotel.Location = new Point(0, 61);
            pcbHotel.Margin = new Padding(3, 4, 3, 4);
            pcbHotel.Name = "pcbHotel";
            pcbHotel.Size = new Size(344, 208);
            pcbHotel.SizeMode = PictureBoxSizeMode.Zoom;
            pcbHotel.TabIndex = 7;
            pcbHotel.TabStop = false;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotelName.Location = new Point(14, 273);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(130, 30);
            lblHotelName.TabIndex = 8;
            lblHotelName.Text = "Hotel Name";
            // 
            // pcbRating
            // 
            pcbRating.Image = (Image)resources.GetObject("pcbRating.Image");
            pcbRating.Location = new Point(17, 305);
            pcbRating.Margin = new Padding(3, 4, 3, 4);
            pcbRating.Name = "pcbRating";
            pcbRating.Size = new Size(123, 76);
            pcbRating.TabIndex = 9;
            pcbRating.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.FromArgb(17, 70, 60);
            lblRating.FlatStyle = FlatStyle.Flat;
            lblRating.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ControlLightLight;
            lblRating.Location = new Point(38, 333);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(34, 24);
            lblRating.TabIndex = 10;
            lblRating.Text = "4,4";
            lblRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.BackColor = Color.FromArgb(230, 240, 231);
            lblReview.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReview.Location = new Point(74, 324);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(37, 22);
            lblReview.TabIndex = 11;
            lblReview.Text = "5.5k";
            // 
            // lblReview2
            // 
            lblReview2.AutoSize = true;
            lblReview2.BackColor = Color.FromArgb(230, 240, 231);
            lblReview2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReview2.Location = new Point(74, 341);
            lblReview2.Name = "lblReview2";
            lblReview2.Size = new Size(64, 22);
            lblReview2.TabIndex = 12;
            lblReview2.Text = "Review!";
            // 
            // lblLokasi
            // 
            lblLokasi.AutoSize = true;
            lblLokasi.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLokasi.Location = new Point(147, 305);
            lblLokasi.Name = "lblLokasi";
            lblLokasi.Size = new Size(108, 24);
            lblLokasi.TabIndex = 13;
            lblLokasi.Text = "Lokasi Hotel";
            // 
            // lblAvaibleRoom
            // 
            lblAvaibleRoom.AutoSize = true;
            lblAvaibleRoom.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvaibleRoom.Location = new Point(169, 360);
            lblAvaibleRoom.Name = "lblAvaibleRoom";
            lblAvaibleRoom.Size = new Size(127, 24);
            lblAvaibleRoom.TabIndex = 15;
            lblAvaibleRoom.Text = "Avaible Rooms";
            // 
            // flpRoom
            // 
            flpRoom.AutoScroll = true;
            flpRoom.BackColor = Color.Transparent;
            flpRoom.Location = new Point(1, 389);
            flpRoom.Margin = new Padding(3, 4, 3, 4);
            flpRoom.Name = "flpRoom";
            flpRoom.Size = new Size(344, 285);
            flpRoom.TabIndex = 16;
            // 
            // frmHotelDesign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 600);
            ControlBox = false;
            Controls.Add(lblAvaibleRoom);
            Controls.Add(lblLokasi);
            Controls.Add(lblReview2);
            Controls.Add(lblReview);
            Controls.Add(lblRating);
            Controls.Add(pcbRating);
            Controls.Add(lblHotelName);
            Controls.Add(pcbHotel);
            Controls.Add(pnlHeader);
            Controls.Add(flpRoom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHotelDesign";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hotel Detail";
            Load += frmHotelDesign_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHotel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHeader;
        private Label lblHotel;
        private Label lblKu;
        private Button btnBack;
        private PictureBox pcbHotel;
        private Label lblHotelName;
        private PictureBox pcbRating;
        private Label lblRating;
        private Label lblReview;
        private Label lblReview2;
        private Label lblLokasi;
        private Label lblAvaibleRoom;
        private FlowLayoutPanel flpRoom;
    }
}