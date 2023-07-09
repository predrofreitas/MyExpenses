using Microsoft.EntityFrameworkCore;

namespace MyExpenses.Models.Contexts
{
    public class MyExpensesDbContext : DbContext
    {
        public MyExpensesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
