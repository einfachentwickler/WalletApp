using DataAccess.Entities;

namespace DataAccess.Repositories;

public interface ITransactionRepository
{
    public Task<IEnumerable<TransactionEntity>> GetAsync(int userId);
}