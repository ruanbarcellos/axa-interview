using AXA.Domain.Entity;
using AXA.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AXA.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ITransactionService service;

        public AccountController(ITransactionService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets all transactions
        /// </summary>
        /// <returns>list of transactions</returns>
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return service.GetAllTransaction();
        }

        /// <summary>
        /// Gets a transaction by its ID
        /// </summary>
        /// <param name="id">transaction id</param>
        /// <returns>a transaction</returns>
        [HttpGet("{id}")]
        public Transaction Get(string id)
        {
            return service.FindById(id);
        }

        /// <summary>
        /// Adds a new transaction
        /// </summary>
        /// <param name="transaction">The transaction to add</param>
        /// <returns>the newly added transaction</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Transaction transaction)
        {
            var newTransaction = service.AddTransaction(transaction);

            return newTransaction != null
                    ? Ok(newTransaction)
                    : (IActionResult)BadRequest();
        }

        /// <summary>
        /// Deletes a transaction
        /// </summary>
        /// <param name="id">the transaction id</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var deletedTransaction = service.RevertTransaction(id);
            return deletedTransaction != null
                    ? Ok(deletedTransaction)
                    : (IActionResult)BadRequest();
        }
    }
}
