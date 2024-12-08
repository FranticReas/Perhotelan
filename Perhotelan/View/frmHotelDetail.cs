using Perhotelan.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perhotelan.View;

namespace Perhotelan.View
{
    public partial class frmHotelDetail : Form
    {
        public frmHotelDetail()
        {
            InitializeComponent();
        }
        private void LoadHotels()
        {
            using (var context = new DdContext())
            {
                var query = "SELECT * FROM hotel INNER JOIN Room ON Hotels.HotelId = Rooms.HotelId";

                using (var cmd = new SQLiteCommand(query, context.Conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {

                        
                    }
                }
        }
            }
        }

    }




