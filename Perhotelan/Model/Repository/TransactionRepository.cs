using Microsoft.VisualBasic.ApplicationServices;
using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
                finally
                {
                    if (_conn.State == System.Data.ConnectionState.Open)
                    {
                        _conn.Close();  // Tutup koneksi
                    }
                }
            }
            return result;
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
        public int CancelTransaction(int transactionId)
        {
            int result = 0;
            string sql = "DELETE FROM Transaction_ WHERE transactionId = @transactionId";


            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@transactionId", transactionId);

                    _conn.Open();  // Buka koneksi
                    result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Transaksi berhasil dibatalkan.");
                    }
                    else
                    {
                        Console.WriteLine("Transaksi tidak ditemukan.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    _conn.Close();  // Tutup koneksi
                }
            }
            return result;
        }

    }
}
