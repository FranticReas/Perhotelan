using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Context;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static QRCoder.PayloadGenerator.SwissQrCode;
using System.Net.Mail;
using System.Net;

namespace Perhotelan.Model.Repository
{
    class UserRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public UserRepository(DdContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Entity.User user)
        {
            int result = 0;
            int newUserId = 0;

            // Ambil nilai maksimum userId di tabel User
            string getMaxUserIdSql = "SELECT COALESCE(MAX(userId), 0) + 1 FROM user";

            using (SQLiteCommand getMaxCmd = new SQLiteCommand(getMaxUserIdSql, _conn))
            {
                try
                {
                    // Eksekusi query untuk mendapatkan userId baru
                    newUserId = Convert.ToInt32(getMaxCmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error while fetching new userId: {0}", ex.Message);
                }
            }

            // Set nilai userId ke properti user
            user.userId = newUserId;

            // Deklarasi perintah SQL untuk insert
            string sql = @"INSERT INTO user (userId, username, email, password, phoneNumber, birthdate)
                   VALUES (@userId, @username, @email, @password, @phoneNumber, @birthdate)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // Daftarkan parameter dan atur nilainya
                cmd.Parameters.AddWithValue("@userId", user.userId);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                cmd.Parameters.AddWithValue("@birthdate", user.birthdate);

                try
                {
                    // Eksekusi perintah INSERT
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }
            public int Update(Entity.User user)
            {
                try
                {
                    string updateQuery = "UPDATE User SET ";

                    // Build update query dynamically based on the fields that are not empty
                    if (!string.IsNullOrEmpty(user.username))
                        updateQuery += "username = @Username, ";
                    if (!string.IsNullOrEmpty(user.email))
                        updateQuery += "email = @Email, ";
                    if (!string.IsNullOrEmpty(user.phoneNumber))
                        updateQuery += "phoneNumber = @PhoneNumber, ";

                    // Remove the last comma and add the WHERE clause
                    updateQuery = updateQuery.TrimEnd(',', ' ') + " WHERE userId = @UserId";

                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, _conn))
                    {
                        if (!string.IsNullOrEmpty(user.username))
                            command.Parameters.AddWithValue("@Username", user.username);
                        if (!string.IsNullOrEmpty(user.email))
                            command.Parameters.AddWithValue("@Email", user.email);
                        if (!string.IsNullOrEmpty(user.phoneNumber))
                            command.Parameters.AddWithValue("@PhoneNumber", user.phoneNumber);

                        command.Parameters.AddWithValue("@UserId", user.userId);

                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating user: {ex.Message}");
                }
            }
        

        public int Delete(Entity.User user)
        {
            int result = 0;

            string sql = @"delete from User where userid = @userId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@userId", user.userId);
                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
                return result;
            }
        }
        public int GetUserId(string email)
        {
            int userId = 0;
            string sql = @"SELECT userid FROM User WHERE email = @Email";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                try
                {
                    // Use ExecuteScalar to get a single value (userId)
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error: {0}", ex.Message);
                }
            }
            return userId;
        }
        public Entity.User GetUserById(int userId)
        {
            Entity.User user = null;
            string sql = "SELECT * FROM User WHERE userId = @userId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Entity.User
                        {
                            userId = Convert.ToInt32(reader["userId"]),
                            username = reader["username"].ToString(),
                            email = reader["email"].ToString(),
                            phoneNumber = reader["phonenumber"].ToString(),
                            birthdate = reader["birthdate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["birthdate"]),
                            imagePath = reader["image"].ToString()
                        };
                    }
                }
            }

            return user;
        }

        public void UpdatePassword(string email, string newPassword)
        {
           
                

                // Update password dan reset token
                string query = "UPDATE User SET password = @Password, reset_token = NULL, token_expiry = NULL WHERE email = @Email";
                using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
                {

                cmd.Parameters.AddWithValue("@Password", newPassword); // Bisa ditambahkan hashing
                cmd.Parameters.AddWithValue("@Email", email);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password successfully reset.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    _conn.Dispose();
                }

                }

                 
        }
        public void GenerateSendToken(string email)
        {
            string checkEmail = "SELECT COUNT(*) FROM User WHERE email = @email";

            using (SQLiteCommand cmd = new SQLiteCommand(checkEmail, _conn))
            {
                try
                {
                    // Cek apakah email benar
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Email not found");
                        return;
                    }

                    // Buat token reset
                    string resetToken = GenerateToken(5);
                    DateTime expiryTime = DateTime.Now.AddMinutes(10); // Berlaku 10 menit

                    // Simpan token ke database
                    string updateToken = "UPDATE User SET reset_token = @token, token_expiry = @expiry WHERE email = @email";
                    using (SQLiteCommand updateCmd = new SQLiteCommand(updateToken, _conn))
                    {
                        updateCmd.Parameters.AddWithValue("@token", resetToken);
                        updateCmd.Parameters.AddWithValue("@expiry", expiryTime);
                        updateCmd.Parameters.AddWithValue("@email", email);
                        updateCmd.ExecuteNonQuery();

                        // Kirim token ke email
                        SendEmail(email, resetToken);
                        MessageBox.Show("Reset Token Sent to Your Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        public string GenerateToken(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // fungsi untuk mengirim email
        public void SendEmail(string email, string token)
        {
            string fromEmail = "hariz.akmal2710@gmail.com"; // email pengirim
            string fromPass = "rtrj xhjg vbou zgyw"; // password email pengirim (password apps)
            string subject = "Password Reset Token";
            string body = $"Your password reset token is : {token}\n\n This token is valid for 10 minutes.";

            try
            {
                // kirim email ke user
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPass);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email : {ex.Message}");
            }
        }
        public bool VerifyToken(string email, string token)
        {
            string query = "SELECT reset_token, token_expiry FROM User WHERE email = @Email";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
            {
                try
                {


                    // Periksa token dan waktu kadaluarsa


                    cmd.Parameters.AddWithValue("@Email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedToken = reader["reset_token"]?.ToString();
                            DateTime? tokenExpiry = reader["token_expiry"] as DateTime?;

                            if (storedToken == token && tokenExpiry.HasValue && tokenExpiry > DateTime.Now)
                            {
                                return true; // Token valid
                            }
                        }
                    }

                    return false; // Token invalid atau kadaluarsa
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            
        }






    }
}
