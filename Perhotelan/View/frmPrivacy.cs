using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using Perhotelan.View;
using Perhotelan.Controller;

namespace Perhotelan.View
{
    public partial class frmPrivacy : Form
    {
        private int _userId;
        public frmPrivacy(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }
    }
}
