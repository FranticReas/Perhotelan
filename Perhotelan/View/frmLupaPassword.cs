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
    public partial class frmLupaPassword : Form
    {
        public event Action ShowResetPass;
        public frmLupaPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please Enter Your Email");
                return;
            }

            using (var context = new DdContext())
            {
                // Inisialisasi repository dan controller
                var userRepository = new UserRepository(context);


                userRepository.GenerateSendToken(email);
            }

            ShowResetPass?.Invoke();
            DialogResult = DialogResult.OK;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

