using Microsoft.EntityFrameworkCore;
using FarmerApi.Entities;

namespace FarmerApi.Data
{
    public class FarmerDbContext : DbContext
    {
        public FarmerDbContext(DbContextOptions<FarmerDbContext> options) : base(options)
        {
        }

        public DbSet<Farmer> Farmers { get; set; }
    }
}
