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

    }
}
