using BusinessLogic.DTO;

namespace BusinessLogic.Handlers.Transactions;

public interface ITransactionsHandler
{
    public Task<IEnumerable<TransactionModel>> GetAsync(int userId);
}