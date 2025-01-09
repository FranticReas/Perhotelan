using Perhotelan.Controller;
using Perhotelan.Model.Context;
using Perhotelan.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan.View
{
    public partial class frmResetPassword : Form
    {


        public event Action ShowLogin;
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string token = txtToken.Text.Trim();
            string newPass = txtNewPassword.Text;

            using (var context = new DdContext())
            {
                // Inisialisasi repository dan controller
                var userRepository = new UserRepository(context);


                if (userRepository.VerifyToken(email, token))
                {
                    userRepository.UpdatePassword(email, newPass);
                    txtEmail.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    txtToken.Text = string.Empty;
                    ShowLogin?.Invoke();
                }
                else
                {
                    MessageBox.Show("Invalid or Expired token");
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
