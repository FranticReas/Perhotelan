﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnSidePanel_Click(object sender, EventArgs e)
        {
            pnlSideBar.Visible = !pnlSideBar.Visible;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblProfile2_Click(object sender, EventArgs e)
        {

        }
    }
}
