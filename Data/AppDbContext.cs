using LearningWebApp.Models;
using Microsoft.EntityFrameworkCore;


namespace LearningWebApp.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
