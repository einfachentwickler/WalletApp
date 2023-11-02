using DataAccess.Entities;
using DataAccess.SeedDataConfiguration;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.WallerAppDbContext;

public class WalletAppDbContext : DbContext
{
    public DbSet<TransactionEntity> Transactions { get; set; }

    public DbSet<UserEntity> Users { get; set; }

    public WalletAppDbContext(DbContextOptions<WalletAppDbContext> options) : base(options) { AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
    }
}