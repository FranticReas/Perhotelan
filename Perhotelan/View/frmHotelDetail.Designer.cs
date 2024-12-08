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
            label1 = new Label();
            lblReview2 = new Label();
            lblLokasi = new Label();
            pcbMap = new PictureBox();
            lblAvaibleRoom = new Label();
            flpRoom = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHotel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMap).BeginInit();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(389, 43);
            pnlHeader.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Montserrat Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(250, 199, 131);
            btnBack.Location = new Point(1, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 43);
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
            lblHotel.Font = new Font("Montserrat Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.ForeColor = SystemColors.ControlLightLight;
            lblHotel.Location = new Point(62, -12);
            lblHotel.Margin = new Padding(0);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(180, 60);
            lblHotel.TabIndex = 15;
            lblHotel.Text = "HOTEL";
            // 
            // lblKu
            // 
            lblKu.AutoEllipsis = true;
            lblKu.AutoSize = true;
            lblKu.BackColor = Color.Transparent;
            lblKu.Font = new Font("Montserrat Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKu.ForeColor = Color.FromArgb(250, 199, 131);
            lblKu.Location = new Point(236, -12);
            lblKu.Margin = new Padding(0);
            lblKu.Name = "lblKu";
            lblKu.Size = new Size(92, 60);
            lblKu.TabIndex = 16;
            lblKu.Text = "KU";
            // 
            // pcbHotel
            // 
            pcbHotel.Location = new Point(12, 51);
            pcbHotel.Name = "pcbHotel";
            pcbHotel.Size = new Size(365, 151);
            pcbHotel.TabIndex = 7;
            pcbHotel.TabStop = false;
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotelName.Location = new Point(12, 205);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(103, 21);
            lblHotelName.TabIndex = 8;
            lblHotelName.Text = "Hotel Name";
            // 
            // pcbRating
            // 
            pcbRating.Image = (Image)resources.GetObject("pcbRating.Image");
            pcbRating.Location = new Point(15, 229);
            pcbRating.Name = "pcbRating";
            pcbRating.Size = new Size(100, 50);
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
            lblRating.Location = new Point(27, 246);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(26, 16);
            lblRating.TabIndex = 10;
            lblRating.Text = "4.8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 240, 231);
            label1.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 241);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 11;
            label1.Text = "5.5k";
            // 
            // lblReview2
            // 
            lblReview2.AutoSize = true;
            lblReview2.BackColor = Color.FromArgb(230, 240, 231);
            lblReview2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReview2.Location = new Point(59, 254);
            lblReview2.Name = "lblReview2";
            lblReview2.Size = new Size(51, 15);
            lblReview2.TabIndex = 12;
            lblReview2.Text = "Review!";
            // 
            // lblLokasi
            // 
            lblLokasi.AutoSize = true;
            lblLokasi.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLokasi.Location = new Point(134, 229);
            lblLokasi.Name = "lblLokasi";
            lblLokasi.Size = new Size(108, 21);
            lblLokasi.TabIndex = 13;
            lblLokasi.Text = "Lokasi Hotel";
            // 
            // pcbMap
            // 
            pcbMap.Image = (Image)resources.GetObject("pcbMap.Image");
            pcbMap.Location = new Point(344, 229);
            pcbMap.Name = "pcbMap";
            pcbMap.Size = new Size(33, 58);
            pcbMap.TabIndex = 14;
            pcbMap.TabStop = false;
            // 
            // lblAvaibleRoom
            // 
            lblAvaibleRoom.AutoSize = true;
            lblAvaibleRoom.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvaibleRoom.Location = new Point(15, 282);
            lblAvaibleRoom.Name = "lblAvaibleRoom";
            lblAvaibleRoom.Size = new Size(101, 16);
            lblAvaibleRoom.TabIndex = 15;
            lblAvaibleRoom.Text = "Avaible Rooms";
            // 
            // flpRoom
            // 
            flpRoom.Location = new Point(15, 301);
            flpRoom.Name = "flpRoom";
            flpRoom.Size = new Size(362, 204);
            flpRoom.TabIndex = 16;
            // 
            // frmHotelDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 504);
            ControlBox = false;
            Controls.Add(flpRoom);
            Controls.Add(lblAvaibleRoom);
            Controls.Add(pcbMap);
            Controls.Add(lblLokasi);
            Controls.Add(lblReview2);
            Controls.Add(label1);
            Controls.Add(lblRating);
            Controls.Add(pcbRating);
            Controls.Add(lblHotelName);
            Controls.Add(pcbHotel);
            Controls.Add(pnlHeader);
            Name = "frmHotelDesign";
            Text = "Hotel Detail";
            Load += frmHotelDesign_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHotel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMap).EndInit();
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
        private Label label1;
        private Label lblReview2;
        private Label lblLokasi;
        private PictureBox pcbMap;
        private Label lblAvaibleRoom;
        private FlowLayoutPanel flpRoom;
    }
}