namespace Perhotelan.View
{
    partial class frmCheckOut
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
            btnOk = new Button();
            btnCancel = new Button();
            lblPickTime = new Label();
            dtpCheckOut = new DateTimePicker();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.FromArgb(17, 70, 60);
            btnOk.Location = new Point(260, 97);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(43, 31);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(17, 70, 60);
            btnCancel.Location = new Point(12, 97);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 31);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPickTime
            // 
            lblPickTime.AutoSize = true;
            lblPickTime.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPickTime.Location = new Point(9, 25);
            lblPickTime.Name = "lblPickTime";
            lblPickTime.Size = new Size(194, 24);
            lblPickTime.TabIndex = 5;
            lblPickTime.Text = "Pilih Tanggal Check-Out";
            lblPickTime.Click += lblPickTime_Click;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.CalendarMonthBackground = Color.FromArgb(230, 240, 231);
            dtpCheckOut.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.Location = new Point(9, 63);
            dtpCheckOut.Margin = new Padding(3, 4, 3, 4);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(289, 26);
            dtpCheckOut.TabIndex = 4;
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 231);
            ClientSize = new Size(316, 141);
            ControlBox = false;
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(lblPickTime);
            Controls.Add(dtpCheckOut);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCheckOut";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmCheckOut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Label lblPickTime;
        private DateTimePicker dtpCheckOut;
    }
}