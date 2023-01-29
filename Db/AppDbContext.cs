using Microsoft.EntityFrameworkCore;
using MovieDatabaseApi.Db.Entities;
using MovieDatabaseApi.Db.Mapping;

namespace MovieDatabaseApi.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MovieEntity> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MovieMap());

            base.OnModelCreating(builder);
        }
    }
}
