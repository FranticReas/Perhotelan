namespace Perhotelan.View
{
    partial class frmCheckIn
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
            dtpCheckIn = new DateTimePicker();
            lblPickTime = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.CalendarMonthBackground = Color.FromArgb(230, 240, 231);
            dtpCheckIn.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.Location = new Point(8, 46);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(200, 22);
            dtpCheckIn.TabIndex = 0;
            // 
            // lblPickTime
            // 
            lblPickTime.AutoSize = true;
            lblPickTime.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPickTime.Location = new Point(8, 17);
            lblPickTime.Name = "lblPickTime";
            lblPickTime.Size = new Size(142, 16);
            lblPickTime.TabIndex = 1;
            lblPickTime.Text = "Pilih Tanggal Check-In";
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(17, 70, 60);
            btnCancel.Location = new Point(8, 75);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(56, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.FromArgb(17, 70, 60);
            btnOk.Location = new Point(174, 75);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(34, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // frmRoomBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 231);
            ClientSize = new Size(220, 106);
            ControlBox = false;
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(lblPickTime);
            Controls.Add(dtpCheckIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRoomBooking";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmRoomBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpCheckIn;
        private Label lblPickTime;
        private Button btnCancel;
        private Button btnOk;
    }
}