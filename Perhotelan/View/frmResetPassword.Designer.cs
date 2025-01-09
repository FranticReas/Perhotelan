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
            lblReset.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblReset.ForeColor = SystemColors.ControlLightLight;
            lblReset.Location = new Point(88, 45);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(211, 27);
            lblReset.TabIndex = 9;
            lblReset.Text = "Reset Password Anda";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 136);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(41, 218);
            txtToken.Margin = new Padding(2);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(288, 27);
            txtToken.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(41, 302);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(288, 27);
            txtNewPassword.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(38, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 27);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblToken.ForeColor = SystemColors.ControlLightLight;
            lblToken.Location = new Point(37, 191);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(68, 27);
            lblToken.TabIndex = 14;
            lblToken.Text = "Token";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblNewPass.ForeColor = SystemColors.ControlLightLight;
            lblNewPass.Location = new Point(39, 274);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(150, 27);
            lblNewPass.TabIndex = 15;
            lblNewPass.Text = "Password Baru";
            lblNewPass.Click += lblNewPass_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(250, 199, 131);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(17, 70, 60);
            btnReset.Location = new Point(41, 371);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 52);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleRole = AccessibleRole.None;
            btnCancel.BackColor = Color.FromArgb(250, 199, 131);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(17, 70, 60);
            btnCancel.Location = new Point(195, 371);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 52);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Batalkan";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(377, 474);
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
            Margin = new Padding(2);
            Name = "frmResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
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