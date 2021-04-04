using System;

namespace AXA.Domain.Entity
{
    /// <summary>
    /// Represents a Transaction
    /// </summary>
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public bool FromPayee { get; set; }
    }
}