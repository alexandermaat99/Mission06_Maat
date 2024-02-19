using Microsoft.EntityFrameworkCore;

namespace Mission06_Maat.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options) // constructor
        {
        }

        public DbSet<Application> Application { get; set; } // property
    }
}
