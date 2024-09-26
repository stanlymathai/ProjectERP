using Microsoft.EntityFrameworkCore;
using ProjectERP.Core.Entities; 

namespace ProjectERP.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Add DbSet properties for each of your entities here
        public DbSet<Device> Devices { get; set; }
    }
}
