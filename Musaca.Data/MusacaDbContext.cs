using Musaca.Models;
using Microsoft.EntityFrameworkCore;

namespace Musaca.Data
{
    public class MusacaDbContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Receipt> Receipts{ get; set; }
        public DbSet<Product> Products{ get; set; }

        public MusacaDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConfiguration.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
