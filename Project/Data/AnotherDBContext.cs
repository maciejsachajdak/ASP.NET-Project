using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class AnotherDBContext : DbContext
    {
        public AnotherDBContext(DbContextOptions<AnotherDBContext> options) : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var modelBuilderExtensions = new ModelBuilderExtensions();
            modelBuilderExtensions.Seed(modelBuilder);
        }
    }
}
