using Microsoft.EntityFrameworkCore;

namespace Mission06_Maat.Models
{
    public class MovieApplicationContext : DbContext // connection from app to database
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options) // constructor
        {
        }

        public DbSet<Application> Application { get; set; } // property
    }
}
