namespace Perhotelan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Initialize the TextBox with placeholder text
            txtLoginEmail.Text = "Masukkan email anda disini"; //Email
            txtLoginEmail.ForeColor = System.Drawing.Color.Gray;
            txtLoginPass.Text = "Masukkan password anda disini"; //Password
            txtLoginPass.ForeColor = System.Drawing.Color.Gray;
            // Attach event handlers
            txtLoginEmail.Enter += txtLoginEmail_Enter; //Email
            txtLoginEmail.Leave += txtLoginEmail_Leave;
            txtLoginPass.Enter += txtLoginPass_Enter; //Password
            txtLoginPass.Leave += txtLoginPass_Leave;
        }
        private void txtLoginEmail_Enter(object sender, EventArgs e) // Email enter
        {
            if (txtLoginEmail.Text == "Masukkan email anda disini")
            {
                txtLoginEmail.Text = "";
                txtLoginEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLoginEmail_Leave(object sender, EventArgs e) //Email leave
        {
            if (string.IsNullOrWhiteSpace(txtLoginEmail.Text))
            {
                txtLoginEmail.Text = "Masukkan email anda disini";
                txtLoginEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtLoginPass_Enter(object sender, EventArgs e) //Password enter
        {
            if (txtLoginEmail.Text == "Masukkan password anda disini")
            {
                txtLoginEmail.Text = "";
                txtLoginEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLoginPass_Leave(object sender, EventArgs e) // Pasword leave
        {
            if (string.IsNullOrWhiteSpace(txtLoginEmail.Text))
            {
                txtLoginEmail.Text = "Masukkan password anda disini";
                txtLoginEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDaftar registerForm = new frmDaftar();
            this.Hide(); // Hide the login form
            registerForm.ShowDialog(); // Show the registration form as a dialog
            this.Show(); // Show the login form again if the registration form is closed
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Sementara
            bool loginSuccessful = true; // Replace this with your actual login validation logic

            if (loginSuccessful)
            {
                this.DialogResult = DialogResult.OK; // Close form and return DialogResult.OK
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
        }

    }
}
