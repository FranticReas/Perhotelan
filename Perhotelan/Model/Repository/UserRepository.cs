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
            int result = 0;

            // Membuat perintah SQL dinamis
            string sql = "UPDATE User SET ";
            List<string> setClauses = new List<string>();
            var parameters = new Dictionary<string, object>();

            // Menambahkan field yang tidak null ke query dan parameter
            if (!string.IsNullOrEmpty(user.username))
            {
                setClauses.Add("username = @username");
                parameters.Add("@username", user.username);
            }
            if (!string.IsNullOrEmpty(user.email))
            {
                setClauses.Add("email = @email");
                parameters.Add("@email", user.email);
            }
            if (!string.IsNullOrEmpty(user.password))
            {
                setClauses.Add("password = @password");
                parameters.Add("@password", user.password);
            }
            if (!string.IsNullOrEmpty(user.phoneNumber))
            {
                setClauses.Add("phoneNumber = @phoneNumber");
                parameters.Add("@phoneNumber", user.phoneNumber);
            }
            if (user.birthdate.HasValue)
            {
                setClauses.Add("birthdate = @birthdate");
                parameters.Add("@birthdate", user.birthdate);
            }
            if (!string.IsNullOrEmpty(user.imagePath))
            {
                setClauses.Add("image = @imagePath");
                parameters.Add("@imagePath", user.imagePath);
            }

            // Jika tidak ada field yang diperbarui, keluar dari method
            if (setClauses.Count == 0)
            {
                throw new ArgumentException("Tidak ada field yang diperbarui.");
            }

            // Menggabungkan field yang ingin diperbarui
            sql += string.Join(", ", setClauses) + " WHERE userId = @userId";
            parameters.Add("@userId", user.userId);

            // Membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // Menambahkan parameter ke command
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                try
                {
                    // Menjalankan perintah UPDATE dan menyimpan hasilnya
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
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
