using Perhotelan.Model.Context;
using Perhotelan.Model.Repository;
using Perhotelan.Model.Entity;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;
using Perhotelan.View;

namespace Perhotelan
{
    public partial class frmLogin : Form
    {

        public event Action ShowResetPass;
       
        public frmLogin()
        {
            InitializeComponent();
            txtLoginPass.PasswordChar = '*';
            this.AcceptButton = btnLogin;
        }
        private void txtLoginEmail_Enter(object sender, EventArgs e) // Email enter
        {

        }
        private void txtLoginEmail_Leave(object sender, EventArgs e) //Email leave
        {

        }
        private void txtLoginPass_Enter(object sender, EventArgs e) //Password enter
        {
            if (txtLoginPass.Text == "Masukkan password anda disini")
            {
                txtLoginPass.Text = "";
                txtLoginPass.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLoginPass_Leave(object sender, EventArgs e) // Pasword leave
        {
            if (string.IsNullOrWhiteSpace(txtLoginPass.Text))
            {
                txtLoginPass.Text = "Masukkan password anda disini";
                txtLoginPass.ForeColor = System.Drawing.Color.Gray;
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
            string email = txtLoginEmail.Text;
            string password = txtLoginPass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password tidak boleh kosong.");
                return;
            }

            using (DdContext context = new DdContext())
            {
                string query = "SELECT userId FROM User WHERE email = @Email AND password = @Password";

                using (var cmd = new SQLiteCommand(query, context.Conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        LoggedInUserId = Convert.ToInt32(result); // Set the userId if login is successful
                        var registerForm = new frmMainMenu(LoggedInUserId);
                        this.Hide(); // Hide the login form
                        registerForm.ShowDialog(); // Show the registration form as a dialog
                        this.Show(); // Show the login form again if the registration form is closed
                    }
                    else
                    {
                        MessageBox.Show("Email atau password salah. Silakan coba lagi.");
                    }
                }
            }
        }
        // Tambahkan properti untuk menyimpan userId yang berhasil login
        public int LoggedInUserId { get; private set; }

        private void lblHotel_Click(object sender, EventArgs e)
        {

        }

        private void lblKu_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtLoginPass, btnShowPass);
            Controls.Add(btnShowPass);
        }
        private void TogglePasswordVisibility(TextBox passwordTextBox, Button showHideButton)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0'; // Show password
                showHideButton.Text = "🙈"; // Change button to indicate hidden state
            }
            else
            {
                passwordTextBox.PasswordChar = '*'; // Hide password
                showHideButton.Text = "👁"; // Change button to indicate visible state
            }
        }

       

        private void lnkLupa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var  formEmail = new frmLupaPassword();
            formEmail.ShowDialog();
            ShowResetPass?.Invoke();
        }
    }
}
