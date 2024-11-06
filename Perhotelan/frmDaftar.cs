using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan
{
    public partial class frmDaftar : Form
    {
        public frmDaftar()
        {
            InitializeComponent();
            
        }

        private void TxtTglLahir_Leave(object sender, EventArgs e)
        {
            DateTime date;
            if (DateTime.TryParseExact(txtTglLahir.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                // Date is valid
                txtTglLahir.ForeColor = Color.Black;
            }
            else
            {
                // Show error if date is invalid
                MessageBox.Show("Masukkan teks dalam format HH/BB/TTTT.");
                txtTglLahir.Focus();
                txtTglLahir.ForeColor = Color.Red;
            }
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

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPass, btnShowPass);
            Controls.Add(btnShowPass);
        }

        private void btnShowPassConfrm_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPassConfrm, btnShowPassConfrm);
            Controls.Add(btnShowPassConfrm);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
