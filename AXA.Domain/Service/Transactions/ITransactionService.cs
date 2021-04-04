using AXA.Domain.Entity;
using System.Collections.Generic;

namespace AXA.Domain.Service
{
    public interface ITransactionService
    {
        /// <summary>
        /// Returns all transactions
        /// </summary>
        IEnumerable<Transaction> GetAllTransaction();

        /// <summary>
        /// Returns a transaction that matches the id
        /// </summary>
        Transaction FindById(string transactionID);

        /// <summary>
        /// Adds a new transaction
        /// </summary>
        Transaction AddTransaction(Transaction transaction);

        /// <summary>
        /// Deletes a transaction
        /// </summary>
        Transaction RevertTransaction(string transactionID);
    }
}