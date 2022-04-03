using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class StarSystemDBContext : DbContext
    {
        /*
        public DbSet<StarSystem> StarSystems { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;Database=space;username=postgres;Password=root;uid=postgres;;Integrated Security=True");
        }
        */

        public StarSystemDBContext(DbContextOptions<StarSystemDBContext> options) : base(options)
        { 
        }

        public DbSet<StarSystem> StarSystems { get; set; }
    }
}
