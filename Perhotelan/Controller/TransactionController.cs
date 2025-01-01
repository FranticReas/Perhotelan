using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using Perhotelan.Model.Context;

namespace Perhotelan.Controller
{
    class TransactionController
    {
        private readonly TransactionRepository _repository;

        // Constructor menerima TransactionRepository sebagai dependency
        public TransactionController(TransactionRepository transactionRepository)
        {
            _repository = transactionRepository;
        }
        // Membuat transaksi baru
        public int CreateTransaction(Transaction_ transaction)
        {
            try
            {
                return _repository.Create(transaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating transaction: {ex.Message}");
                return 0; // Indikator kegagalan
            }
        }
        // Mendapatkan transaksi berdasarkan userId
        public List<Transaction_> GetTransactionsByUserId(int userId)
        {
            try
            {
                return _repository.GetTransactionsByUserId(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching transactions: {ex.Message}");
                return new List<Transaction_>();
            }
        }
        // Mendapatkan roomId dari transaksi berdasarkan userId
        public int GetRoomIdByUserId(int userId)
        {
            try
            {
                return _repository.GetRoomIdByTransaction(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching roomId: {ex.Message}");
                return 0; // Indikator kegagalan
            }
        }
        // Memperbarui status transaksi
        public void UpdateTransactionStatus(int transactionId, string status)
        {
            try
            {
                _repository.UpdateTransactionStatus(transactionId, status);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating transaction status: {ex.Message}");
            }
        }
        // Mendapatkan transaksi berdasarkan transactionId
        public Transaction_ GetTransactionById(int transactionId)
        {
            try
            {
                return _repository.GetTransactionById_(transactionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching transaction: {ex.Message}");
                return null; // Indikator kegagalan
            }
        }
    }
}
