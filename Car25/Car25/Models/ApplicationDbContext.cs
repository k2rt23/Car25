using CarManager.Models;
using Microsoft.EntityFrameworkCore;

namespace Car25.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
