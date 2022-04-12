using Microsoft.EntityFrameworkCore;

namespace NewsApp.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<News> News { get; set; }
    }
}
