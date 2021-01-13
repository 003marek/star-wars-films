
using Microsoft.EntityFrameworkCore;
using StarWarsFilms.Models;

namespace StarWarsFilms.Database
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { Database.EnsureCreated(); }
        public DbSet<RatingEntity> Ratings { get; set; }
    }
}
