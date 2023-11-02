using DataAccess.Entities;
using DataAccess.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedDataConfiguration;

public class TransactionConfiguration : IEntityTypeConfiguration<TransactionEntity>
{
    public void Configure(EntityTypeBuilder<TransactionEntity> builder)
    {
        List<TransactionEntity> user1Transactions = new()
        {
            new TransactionEntity
            {
                Id = 1,
                Amount = 12.13,
                IsAutorizedUser = true,
                Date = DateTime.UtcNow,
                Description = "Some description 1",
                IsPending = true,
                Name = "Transaction 1",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 2,
                Amount = 12.15,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2002/12/12 12:12:12"),
                Description = "Some description 2",
                IsPending = false,
                Name = "Transaction 2",
                Type = TransactionType.Credit,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 3,
                Amount = 1256,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2002/12/12 12:12:12"),
                Description = "Some description 3",
                IsPending = false,
                Name = "Transaction 3",
                Type = TransactionType.Credit,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 4,
                Amount = 1256,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 4",
                IsPending = false,
                Name = "Transaction 4",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 5,
                Amount = 456,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 5",
                IsPending = false,
                Name = "Transaction 5",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 6,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 6",
                IsPending = false,
                Name = "Transaction 6",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 7,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 7",
                IsPending = false,
                Name = "Transaction 7",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 8,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 8",
                IsPending = false,
                Name = "Transaction 8",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 9,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 8",
                IsPending = false,
                Name = "Transaction 9",
                Type = TransactionType.Payment,
                UserId = 1
            },
            new TransactionEntity
            {
                Id = 10,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 10",
                IsPending = false,
                Name = "Transaction 10",
                Type = TransactionType.Payment,
                UserId = 1
            }
        };

        List<TransactionEntity> user2Transactions = new()
        {
            new TransactionEntity
            {
                Id = 11,
                Amount = 12.13,
                IsAutorizedUser = true,
                Date = DateTime.UtcNow,
                Description = "Some description 1",
                IsPending = true,
                Name = "Transaction 1",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 12,
                Amount = 12.15,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2002/12/12 12:12:12"),
                Description = "Some description 2",
                IsPending = false,
                Name = "Transaction 2",
                Type = TransactionType.Credit,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 13,
                Amount = 1256,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2002/12/12 12:12:12"),
                Description = "Some description 3",
                IsPending = false,
                Name = "Transaction 3",
                Type = TransactionType.Credit,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 14,
                Amount = 1256,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 4",
                IsPending = false,
                Name = "Transaction 4",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 15,
                Amount = 456,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 5",
                IsPending = false,
                Name = "Transaction 5",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 16,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 6",
                IsPending = false,
                Name = "Transaction 6",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 17,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 7",
                IsPending = false,
                Name = "Transaction 7",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 18,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 8",
                IsPending = false,
                Name = "Transaction 8",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 19,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 8",
                IsPending = false,
                Name = "Transaction 9",
                Type = TransactionType.Payment,
                UserId = 2
            },
            new TransactionEntity
            {
                Id = 20,
                Amount = 189.92,
                IsAutorizedUser = false,
                Date = DateTime.Parse("2023/11/02 12:12:12"),
                Description = "Some description 10",
                IsPending = false,
                Name = "Transaction 10",
                Type = TransactionType.Payment,
                UserId = 2
            }
        };

        builder.HasData(user1Transactions.Union(user2Transactions));
    }
}