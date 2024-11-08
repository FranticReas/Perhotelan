namespace Perhotelan
{
    partial class frmCancelConfirmation
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
            lblCancelBooking = new Label();
            lblConfirmation = new Label();
            lblPolicy = new Label();
            label3 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCancelBooking
            // 
            lblCancelBooking.AutoSize = true;
            lblCancelBooking.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelBooking.ForeColor = Color.Red;
            lblCancelBooking.Location = new Point(124, 9);
            lblCancelBooking.Name = "lblCancelBooking";
            lblCancelBooking.Size = new Size(132, 20);
            lblCancelBooking.TabIndex = 0;
            lblCancelBooking.Text = "Batalkan Booking";
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(26, 57);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(332, 40);
            lblConfirmation.TabIndex = 1;
            lblConfirmation.Text = "Apakah anda ingin lanjut untuk membatalkan \r\nbooking anda?";
            lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPolicy
            // 
            lblPolicy.AutoSize = true;
            lblPolicy.Location = new Point(53, 113);
            lblPolicy.Name = "lblPolicy";
            lblPolicy.Size = new Size(281, 30);
            lblPolicy.TabIndex = 2;
            lblPolicy.Text = "hanya 80% yang bisa di balikkan dari transaksi anda \r\nmenurut kebijakan kami";
            lblPolicy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(367, 15);
            label3.TabIndex = 3;
            label3.Text = "________________________________________________________________________";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(225, 204);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(133, 49);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Ya, Lanjutkan";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 255, 192);
            btnCancel.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnCancel.ForeColor = Color.DarkGreen;
            btnCancel.Location = new Point(53, 204);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 49);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Tidak";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCancelConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 289);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(lblPolicy);
            Controls.Add(lblConfirmation);
            Controls.Add(lblCancelBooking);
            Name = "frmCancelConfirmation";
            Text = "Batalkan Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblCancelBooking;
        private Label lblConfirmation;
        private Label lblPolicy;
        private Label label3;
        private Button btnConfirm;
        private Button btnCancel;
    }
}