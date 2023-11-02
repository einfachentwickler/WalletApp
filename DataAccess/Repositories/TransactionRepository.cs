using DataAccess.Entities;
using DataAccess.WallerAppDbContext;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly WalletAppDbContext _db;

    public TransactionRepository(WalletAppDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<TransactionEntity>> GetAsync(int userId)
    {
        return await _db.Transactions.AsNoTracking().Where(transaction => transaction.UserId == userId).Include(transaction => transaction.User).ToListAsync();
    }
}