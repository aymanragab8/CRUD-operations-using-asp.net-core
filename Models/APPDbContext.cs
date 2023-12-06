using Microsoft.EntityFrameworkCore;

namespace TestApi.Models
{
    public class APPDbContext :DbContext
    {
        public APPDbContext(DbContextOptions<APPDbContext> options) : base(options)
        {
            
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
