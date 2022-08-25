using CookBook.Domain;
using CookBook.Domain.Recipe;
using CookBook.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Infrastructure
{
    public class CookBookDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Recipe> Recipe { get; set; }

        public CookBookDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RecipeMap());
        }
    }
}

