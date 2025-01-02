using BackendForex.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendForex.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Wallets> Wallets { get; set; }
    }
}
