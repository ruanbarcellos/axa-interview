using AXA.Domain.Entity;
using AXA.Domain.Repository;


namespace AXA.Infrastructure.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
    }
}