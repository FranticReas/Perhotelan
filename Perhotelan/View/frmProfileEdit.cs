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

namespace Perhotelan.View
{
    public partial class frmEditProfile : Form
    {
        private int _userId;
        public frmEditProfile(int userId)
        {
            _userId = userId;
            InitializeComponent();
            LoadUserProfile();

        }

        private void LoadUserProfile()
        {
            try
            {
                using (DdContext context = new DdContext())
                {
                    string query = "SELECT username, email, phoneNumber FROM User WHERE userId = @UserId";
                    using (SQLiteCommand command = new SQLiteCommand(query, context.Conn))
                    {
                        command.Parameters.AddWithValue("@UserId", _userId);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["username"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhoneNumber.Text = reader["phoneNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi error saat memuat profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string updatedName = txtName.Text;
            string updatedEmail = txtEmail.Text;
            string updatedPhoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(updatedName) && string.IsNullOrEmpty(updatedEmail) && string.IsNullOrEmpty(updatedPhoneNumber))
            {
                MessageBox.Show("Tidak ada perubahan data yang dilakukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (DdContext context = new DdContext())
                {
                    string updateQuery = "UPDATE User SET ";

                    // Build update query dynamically based on the fields that are not empty
                    if (!string.IsNullOrEmpty(updatedName))
                        updateQuery += "username = @Username, ";
                    if (!string.IsNullOrEmpty(updatedEmail))
                        updateQuery += "email = @Email, ";
                    if (!string.IsNullOrEmpty(updatedPhoneNumber))
                        updateQuery += "phoneNumber = @PhoneNumber, ";

                    // Remove the last comma and add the WHERE clause
                    updateQuery = updateQuery.TrimEnd(',', ' ') + " WHERE userId = @UserId";

                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, context.Conn))
                    {
                        // Add parameters for only the fields that are being updated
                        if (!string.IsNullOrEmpty(updatedName))
                            command.Parameters.AddWithValue("@Username", updatedName);
                        if (!string.IsNullOrEmpty(updatedEmail))
                            command.Parameters.AddWithValue("@Email", updatedEmail);
                        if (!string.IsNullOrEmpty(updatedPhoneNumber))
                            command.Parameters.AddWithValue("@PhoneNumber", updatedPhoneNumber);

                        command.Parameters.AddWithValue("@UserId", _userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profil berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after updating
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada perubahan yang dilakukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memperbarui profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
