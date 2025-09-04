using Microsoft.EntityFrameworkCore;

namespace PFA.DB
{
    public class FinanceDbContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<IncomeSource> IncomeSources { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
            : base(options)
        {
        }
        public FinanceDbContext()
        {
        }

    }
}
