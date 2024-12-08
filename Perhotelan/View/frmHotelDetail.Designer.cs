namespace Perhotelan.View
{
    partial class frmHotelDetail
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
            pnlHeader = new Panel();
            flpHotelDetail = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 70, 60);
            pnlHeader.Controls.Add(flpHotelDetail);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(389, 46);
            pnlHeader.TabIndex = 6;
            // 
            // flpHotelDetail
            // 
            flpHotelDetail.Location = new Point(0, 39);
            flpHotelDetail.Name = "flpHotelDetail";
            flpHotelDetail.Size = new Size(389, 413);
            flpHotelDetail.TabIndex = 7;
            // 
            // frmHotelDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(pnlHeader);
            Name = "frmHotelDetail";
            Text = "frmHotelDetail";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private FlowLayoutPanel flpHotelDetail;
    }
}