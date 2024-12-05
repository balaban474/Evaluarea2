using Microsoft.EntityFrameworkCore;
using ProductInventoryApp.Models;
using System.Collections.Generic;

namespace ProductInventoryApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
