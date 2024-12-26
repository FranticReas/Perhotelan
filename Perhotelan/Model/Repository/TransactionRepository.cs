using Microsoft.VisualBasic.ApplicationServices;
using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Perhotelan.Model.Repository
{
    class TransactionRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public TransactionRepository(DdContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public List<Transaction_> GetTransactions(int userId)
        {
            List<Transaction_> transactions = new List<Transaction_>();
            string query = "SELECT * FROM Transaction_ WHERE userId = @userId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    while (reader.Read())
                    {
                        var transaction = new Transaction_
                        {
                            transactionId = Convert.ToInt32(reader["transactionId"]),
                            transactionDate = Convert.ToDateTime(reader["transactionDate"]),
                            checkIn = Convert.ToDateTime(reader["checkIn"]),
                            checkOut = Convert.ToDateTime(reader["checkOut"]),
                            status = reader["status"].ToString(),
                            price = Convert.ToInt32(reader["price"]),
                            roomId = Convert.ToInt32(reader["roomId"]),
                            userId = Convert.ToInt32(reader["userId"])
                        };

                        transactions.Add(transaction);
                    }
                }
            }
            return transactions;
        }
        public int Create(Transaction_ transaction)
        {
            int result = 0;
            int newTrasactionId = 0;

            // Ambil nilai maksimum userId di tabel User
            string getMaxTransactionIdSql = "SELECT COALESCE(MAX(transactionId), 0) + 1 FROM Transaction_";

            using (SQLiteCommand getMaxCmd = new SQLiteCommand(getMaxTransactionIdSql, _conn))
            {
                try
                {
                    newTrasactionId = Convert.ToInt32(getMaxCmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error while fetching new transactionId: {0}", ex.Message);
                }
            }

            // Set nilai userId ke properti user
            transaction.transactionId = newTrasactionId;

            // Deklarasi perintah SQL untuk insert
            string sql = @"INSERT INTO Transaction_ (transactionId, transactionDate, checkIn, checkOut, status, price, roomId, userId)
            VALUES (@transactionId, @transactionDate, @checkIn, @checkOut, @status, @price, @roomId, @userId)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@transactionId", transaction.transactionId);
                cmd.Parameters.AddWithValue("@transactionDate", transaction.transactionDate);
                cmd.Parameters.AddWithValue("@checkIn", transaction.checkIn);
                cmd.Parameters.AddWithValue("@checkOut", transaction.checkOut);
                cmd.Parameters.AddWithValue("@status", transaction.status);
                cmd.Parameters.AddWithValue("@price", transaction.price);
                cmd.Parameters.AddWithValue("@roomId", transaction.roomId);
                cmd.Parameters.AddWithValue("@userId", transaction.userId);
                try
                {
                    // Eksekusi perintah INSERT
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while creating transaction: {ex.Message}\n{ex.StackTrace}",
                     "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.Print("Create error: {0}\n{1}", ex.Message, ex.StackTrace);
                }
            }
            return result;
        }
        public int UpdateTransaction(Transaction_ transaction)
        {
            int result = 0;

            // Membuat perintah SQL dinamis
            string sql = "UPDATE Transaction_ SET status = @status WHERE userId = @userId AND transactionId = @transactionId";

            using (DdContext context = new DdContext())
            {
                using (var cmd = new SQLiteCommand(sql, _conn))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@status", transaction.status);
                    cmd.Parameters.AddWithValue("@userId", transaction.userId);
                    cmd.Parameters.AddWithValue("@transactionId", transaction.transactionId);

                    // Open the connection
                    _conn.Open();
                    try
                    {
                        // Execute the command and get the number of affected rows
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                    }
                }
            }
            return result;
        }
        public int DeleteOldCompletedTransactions(DateTime cutoffDate)
        {
            int result = 0;

            // Define the SQL command to delete old completed transactions
            string sql = @"DELETE FROM Transaction_ 
                   WHERE transactionDate < @cutoffDate AND status = @status";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // Register parameters and set their values
                cmd.Parameters.AddWithValue("@cutoffDate", cutoffDate);
                cmd.Parameters.AddWithValue("@status", "completed");

                try
                {
                    // Execute the DELETE command and get the number of affected rows
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int GetTransactionCountByUserId(int userId)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM Transaction_ WHERE userId = @UserId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error getting transaction count: {0}", ex.Message);
                }
            }
            return count;
        }
        public List<Transaction_> GetTransactionsByUserId(int userId)
        {
            List<Transaction_> transactions = new List<Transaction_>();
            string sql = "SELECT * FROM Transaction_ WHERE userId = @userId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new Transaction_
                        {
                            transactionId = Convert.ToInt32(reader["transactionId"]),
                            transactionDate = Convert.ToDateTime(reader["transactionDate"]),
                            checkIn = Convert.ToDateTime(reader["checkIn"]),
                            checkOut = Convert.ToDateTime(reader["checkOut"]),
                            status = reader["status"].ToString(),
                            price = Convert.ToInt32(reader["price"]),
                            roomId = Convert.ToInt32(reader["roomId"]),
                            userId = Convert.ToInt32(reader["userId"])
                        });
                    }
                }
            }

            return transactions;
        }
        public int GetRoomIdByTransaction(int userId)
        {
            int result = 0;
            string sql = "SELECT roomId FROM Transaction_ WHERE userId = @userId";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            result = Convert.ToInt32(reader["roomId"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print("Error while fetching new transactionId: {0}", ex.Message);
                    }
                }
            }
            return result;
        }
        public void UpdateTransactionStatus(int transactionId, string status)
        {
            string query = "UPDATE Transaction_ SET status = @status WHERE transactionId = @transactionId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                cmd.ExecuteNonQuery();
            }
        }
        public Transaction_ GetTransactionById(int transactionId, UserRepository userRepository)
        {
            Transaction_ transaction = null;
            string sql = "SELECT * FROM Transaction_ WHERE transactionId = @transactionId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@transactionId", transactionId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        transaction = new Transaction_
                        {
                            transactionId = Convert.ToInt32(reader["transactionId"]),
                            transactionDate = Convert.ToDateTime(reader["transactionDate"]),
                            checkIn = Convert.ToDateTime(reader["checkIn"]),
                            checkOut = Convert.ToDateTime(reader["checkOut"]),
                            status = reader["status"].ToString(),
                            price = Convert.ToInt32(reader["price"]),
                            roomId = Convert.ToInt32(reader["roomId"]),
                            userId = Convert.ToInt32(reader["userId"])
                        };

                        // Ambil data user terkait
                        var user = userRepository.GetUserById(transaction.userId);
                        if (user != null)
                        {
                            transaction.UserFullName = user.username;
                            transaction.UserPhoneNumber = user.phoneNumber;
                        }
                    }
                }
            }

            return transaction;
        }
        public Transaction_ GetTransactionById_(int transactionId)
        {
            Transaction_ transaction = null;
            string sql = "SELECT * FROM Transaction_ WHERE transactionId = @transactionId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@transactionId", transactionId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        transaction = new Transaction_
                        {
                            transactionId = Convert.ToInt32(reader["transactionId"]),
                            transactionDate = Convert.ToDateTime(reader["transactionDate"]),
                            checkIn = Convert.ToDateTime(reader["checkIn"]),
                            checkOut = Convert.ToDateTime(reader["checkOut"]),
                            status = reader["status"].ToString(),
                            price = Convert.ToInt32(reader["price"]),
                            roomId = Convert.ToInt32(reader["roomId"]),
                            userId = Convert.ToInt32(reader["userId"])
                        };
                    }
                }
            }
            return transaction;
        }

    }
}
