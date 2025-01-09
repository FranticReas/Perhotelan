namespace Perhotelan.View
{
    partial class frmLupaPassword
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
            lblEmailSend = new Label();
            txtEmail = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblEmailSend
            // 
            lblEmailSend.AutoSize = true;
            lblEmailSend.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            lblEmailSend.ForeColor = SystemColors.ControlLightLight;
            lblEmailSend.Location = new Point(94, 47);
            lblEmailSend.Name = "lblEmailSend";
            lblEmailSend.Size = new Size(243, 24);
            lblEmailSend.TabIndex = 8;
            lblEmailSend.Text = "Send Token to Your Email";
            lblEmailSend.Click += lblEmailSend_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 109);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(250, 199, 131);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Montserrat ExtraBold", 10.2F, FontStyle.Bold);
            btnSend.ForeColor = Color.FromArgb(17, 70, 60);
            btnSend.Location = new Point(136, 173);
            btnSend.Margin = new Padding(2, 2, 2, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(141, 50);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // frmLupaPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(429, 262);
            ControlBox = false;
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(lblEmailSend);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmLupaPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelKu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmailSend;
        private TextBox txtEmail;
        private Button btnSend;
    }
}