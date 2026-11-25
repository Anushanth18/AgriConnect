using AgriSupplierApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgriSupplierApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}