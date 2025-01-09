namespace Perhotelan.View
{
    partial class frmResetPassword
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
            lblReset = new Label();
            txtEmail = new TextBox();
            txtToken = new TextBox();
            txtNewPassword = new TextBox();
            lblEmail = new Label();
            lblToken = new Label();
            lblNewPass = new Label();
            btnReset = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblReset
            // 
            lblReset.AutoSize = true;
            lblReset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReset.ForeColor = SystemColors.ControlLightLight;
            lblReset.Location = new Point(176, 113);
            lblReset.Margin = new Padding(4, 0, 4, 0);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(203, 22);
            lblReset.TabIndex = 9;
            lblReset.Text = "Reset Your Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(359, 31);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(115, 344);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(359, 31);
            txtToken.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(115, 470);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(359, 31);
            txtNewPassword.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(115, 185);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 22);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToken.ForeColor = SystemColors.ControlLightLight;
            lblToken.Location = new Point(115, 290);
            lblToken.Margin = new Padding(4, 0, 4, 0);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(66, 22);
            lblToken.TabIndex = 14;
            lblToken.Text = "Token";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPass.ForeColor = SystemColors.ControlLightLight;
            lblNewPass.Location = new Point(115, 411);
            lblNewPass.Margin = new Padding(4, 0, 4, 0);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(142, 22);
            lblNewPass.TabIndex = 15;
            lblNewPass.Text = "New Password";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(212, 571);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(362, 571);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(556, 750);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnReset);
            Controls.Add(lblNewPass);
            Controls.Add(lblToken);
            Controls.Add(lblEmail);
            Controls.Add(txtNewPassword);
            Controls.Add(txtToken);
            Controls.Add(txtEmail);
            Controls.Add(lblReset);
            Name = "frmResetPassword";
            Text = "HotelKu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReset;
        private TextBox txtEmail;
        private TextBox txtToken;
        private TextBox txtNewPassword;
        private Label lblEmail;
        private Label lblToken;
        private Label lblNewPass;
        private Button btnReset;
        private Button btnCancel;
    }
}