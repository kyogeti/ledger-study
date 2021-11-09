using LedgerStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LedgerStudy.Infra.Context
{
    public class DefaultContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Batch> Batches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LedgerStudy");
            base.OnConfiguring(optionsBuilder);
        }
    }
}