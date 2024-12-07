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
            lblConfirmation = new Label();
            lblPolicy = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(26, 9);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(332, 40);
            lblConfirmation.TabIndex = 1;
            lblConfirmation.Text = "Apakah anda ingin lanjut untuk membatalkan \r\nbooking anda?";
            lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPolicy
            // 
            lblPolicy.AutoSize = true;
            lblPolicy.ForeColor = Color.FromArgb(192, 0, 0);
            lblPolicy.Location = new Point(49, 60);
            lblPolicy.Name = "lblPolicy";
            lblPolicy.Size = new Size(278, 30);
            lblPolicy.TabIndex = 2;
            lblPolicy.Text = "hanya 80% yang bisa dibalikkan dari transaksi anda \r\nmenurut kebijakan kami";
            lblPolicy.TextAlign = ContentAlignment.MiddleCenter;
            lblPolicy.Click += lblPolicy_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(251, 86, 68);
            btnConfirm.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(249, 93);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(109, 38);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Ya, Lanjutkan";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(44, 190, 142);
            btnCancel.Font = new Font("Franklin Gothic Medium", 11.25F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(26, 93);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Tidak";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCancelConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 143);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblPolicy);
            Controls.Add(lblConfirmation);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblConfirmation;
        private Label lblPolicy;
        private Button btnConfirm;
        private Button btnCancel;
    }
}