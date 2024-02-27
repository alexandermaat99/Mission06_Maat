using Microsoft.EntityFrameworkCore;
using Mission06_Maat.Models;

namespace Mission06_Maat.Data
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options)
            : base(options)
        {
        }

        // DbSet for Movies
        public DbSet<Movie> Movies { get; set; }

        // DbSet for Categories (if you decide to use it)
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // If you have any specific configurations for your entities, set them here
            // For example, specifying table names or relationships
        }
    }
}
