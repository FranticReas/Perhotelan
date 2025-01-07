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
            lblEmailSend.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailSend.ForeColor = SystemColors.ControlLightLight;
            lblEmailSend.Location = new Point(144, 163);
            lblEmailSend.Margin = new Padding(4, 0, 4, 0);
            lblEmailSend.Name = "lblEmailSend";
            lblEmailSend.Size = new Size(244, 22);
            lblEmailSend.TabIndex = 8;
            lblEmailSend.Text = "Send Token to Your Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(406, 31);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(217, 376);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // frmLupaPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 70, 60);
            ClientSize = new Size(556, 750);
            ControlBox = false;
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(lblEmailSend);
            Name = "frmLupaPassword";
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