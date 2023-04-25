using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Contexts
{
    public class AppDbContext : DbContext
    {
        // Syntax
        public AppDbContext( DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        // After creating Model we must create property
        public DbSet<Service> Services { get; set; }
        // Services -> Name of Table 
    }
}
