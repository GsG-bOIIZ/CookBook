using CookBook.Domain;
using CookBook.Infrastructure.Configuration;
using CookBook.Infrastructure.UoW;
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

