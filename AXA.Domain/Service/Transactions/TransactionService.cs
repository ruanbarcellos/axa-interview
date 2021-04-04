using AXA.Domain.Entity;
using AXA.Domain.Repository;
using System;
using System.Collections.Generic;

namespace AXA.Domain.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository repository;

        public TransactionService(ITransactionRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Transaction> GetAllTransaction()
        {
            return repository.GetAll();
        }

        public Transaction FindById(string transactionID)
        {
            return repository.FirstOrDefault(t => t.ID == Guid.Parse(transactionID));
        }

        public Transaction AddTransaction(Transaction transaction)
        {
            if (!IsValid(transaction)) return null;

            transaction.ID = Guid.NewGuid();
            return repository.Add(transaction);
        }

        public Transaction RevertTransaction(string transactionID)
        {
            var transaction = FindById(transactionID);
            if (transaction == null) return null;
            
            repository.Remove(t => t.ID == Guid.Parse(transactionID));
            return transaction;
        }

        private bool IsValid(Transaction transaction)
        {
            if (transaction.Amount <= 0) return false;
            if (transaction.Date == null) return false;
            if (string.IsNullOrWhiteSpace(transaction.Description)) return false;

            return true;
        }
    }
}