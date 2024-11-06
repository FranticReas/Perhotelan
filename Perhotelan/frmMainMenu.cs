using System;
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

            IntializedMenuInterface();

            
            this.Controls.Add(txtSearch);           
        }

        private void IntializedMenuInterface()
        {
            // Sementara
            for (int i = 0; i < 5; i++)
            {
                AddCard("Hotel " + (i + 1), "🌟🌟🌟🌟🌟", "💲💲💲💲💲💲💲💲💲💲");
            }
        }
        private void AddCard(string hotelName, string hotelRating, string hotelPricing)
        {
            Panel card = new Panel
            {
                Size = new Size(350, 100),
                BackColor = Color.FromArgb(100, 181, 246),
                Margin = new Padding(5)
            };

            Label titleLabel = new Label
            {
                Text = hotelName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10)
            };
            card.Controls.Add(titleLabel);

            Label subtitleLabel = new Label
            {
                Text = hotelRating,
                Font = new Font("Segoe UI", 5, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(10, 35)
            };
            card.Controls.Add(subtitleLabel);

            Label instructorLabel = new Label
            {
                Text = hotelPricing,
                Font = new Font("Segoe UI", 5, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(10, 80)
            };
            card.Controls.Add(instructorLabel);

            flpMenu.Controls.Add(card);
        }
        private void btnSidePanel_Click(object sender, EventArgs e)
        {
            pnlSideBar.Visible = !pnlSideBar.Visible;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblProfile2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Focus();

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (Panel card in flpMenu.Controls.OfType<Panel>())
            {
                Label titleLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold);

                if (titleLabel != null)
                {
                    bool isMatch = titleLabel.Text.ToLower().Contains(searchText);
                    card.Visible = isMatch;
                }
            }
        }
    }
}
