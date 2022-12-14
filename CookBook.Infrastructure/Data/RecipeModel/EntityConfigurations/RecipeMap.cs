using CookBook.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookBook.Infrastructure.Configuration
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnType("int");
            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.CookingTime).HasColumnType("int");
            builder.Property(x => x.Portions).HasColumnType("int");
            builder.Property(x => x.Stars).HasColumnType("int");
            builder.Property(x => x.Likes).HasColumnType("int");
        }
    }
}