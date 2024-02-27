using Mission06_Maat.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using Mission06_Maat.Models;

namespace Mission06_Maat.Models
{
    public class AddMoviesContext : DbContext
    {
        public AddMoviesContext(DbContextOptions<AddMoviesContext> options) : base(options) //contructor
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}