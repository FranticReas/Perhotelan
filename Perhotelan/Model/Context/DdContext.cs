using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;


namespace Perhotelan.Model.Context
{
    class DdContext : IDisposable
    {
        // deklarasi private variabel / field
        private SQLiteConnection _conn;
        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        // Method untuk melakukan koneksi ke database
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // declare connection object
            try
            {
                // Get the full path of the database
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string dbName = @"D:\Pemrograman Lanjut\Perhotelan\Perhotelan\database\hotelapp.db";


                // Check if the database file exists
                if (!File.Exists(dbName))
                {
                    throw new FileNotFoundException("Database file not found.", dbName);
                }

                // Declare connection string
                string connectionString = $"Data Source={dbName}; FailIfMissing=True;";

                // Initialize and open the connection
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex) // handle errors
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                throw new InvalidOperationException("Could not open database connection.", ex);
            }
            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed)
                    {
                        _conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error closing connection: {0}", ex.Message);
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
