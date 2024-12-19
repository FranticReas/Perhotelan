using Perhotelan.Model.Context;
using System.Data.SQLite;

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
            string email = txtLoginEmail.Text; // Ambil email dari TextBox
            string password = txtLoginPass.Text; // Ambil password dari TextBox

            // Validasi input kosong
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password tidak boleh kosong.");
                return;
            }

            // Gunakan repository atau koneksi langsung ke database
            using (DdContext context = new DdContext())
            {
                // Query untuk validasi login
                string query = "SELECT COUNT(*) FROM User WHERE email = @Email AND password = @Password";

                using (var cmd = new SQLiteCommand(query, context.Conn))
                {
                    // Tambahkan parameter ke query
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Eksekusi query dan ambil hasil
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {                     
                        this.DialogResult = DialogResult.OK; // Tutup form dan set DialogResult.OK
                    }
                    else
                    {
                        // Login gagal
                        MessageBox.Show("Email atau password salah. Silakan coba lagi.");
                    }
                }
            }
        }

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
    }
}
