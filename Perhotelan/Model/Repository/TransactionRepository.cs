using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
            string query = "SELECT * FROM Transaction WHERE userId = @userId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transaction = new Transaction_
                        {
                            transactionId = Convert.ToInt32(reader["transactionId"]),
                            transactionDate = Convert.ToDateTime(reader["transactionDate"]),
                            checkIn = Convert.ToDateTime(reader["checkIn"]),
                            checkOut = Convert.ToDateTime(reader["checkOut"]),
                            status = reader["status"].ToString(),
                            price = reader["price"].ToString(),
                            roomId = Convert.ToInt32(reader["roomId"]),
                            userId = Convert.ToInt32(reader["userId"])
                        };

                        transactions.Add(transaction);
                    }
                }
            }
            return transactions;
        }
        public int CreateTransaction(Transaction_ transaction)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"INSERT INTO Transaction (transactionId, transactionDate, checkIn, checkOut, roomId, price, userId)
            VALUES (@transactionId, @transactionDate, @checkIn, @checkOut, @roomId, @price, @userId)";
            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@transactionid", transaction.transactionId);
                cmd.Parameters.AddWithValue("@transactionDate", transaction.transactionDate);
                cmd.Parameters.AddWithValue("@checkIn", transaction.checkIn);
                cmd.Parameters.AddWithValue("@checkOut", transaction.checkOut);
                cmd.Parameters.AddWithValue("@roomId", transaction.roomId);
                cmd.Parameters.AddWithValue("@price", transaction.price);
                cmd.Parameters.AddWithValue("@userId", transaction.userId);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int UpdateTransaction(Transaction_ transaction)
        {
            int result = 0;

            // Membuat perintah SQL dinamis
            string sql = "UPDATE Transaction SET status = @status WHERE userId = @userId AND transactionId = @transactionId";

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
            string sql = @"DELETE FROM Transaction 
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

    }
}
