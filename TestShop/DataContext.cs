using Microsoft.EntityFrameworkCore;
using TestShop.Moduls;

namespace TestShop
{
    public sealed class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}