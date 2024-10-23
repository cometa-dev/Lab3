using Microsoft.EntityFrameworkCore;
using ShopApplication.Models;

namespace ShopApplication.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shop.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}