using Microsoft.EntityFrameworkCore;
using HelloApi.Models;

namespace HelloApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Calories { get; set; }
    }
}
