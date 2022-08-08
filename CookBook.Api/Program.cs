using CookBook.Api.Services;
using CookBook.Infrastructure;
using CookBook.Infrastructure.Repository;
using CookBook.Infrastructure.UoW;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            builder.Services.AddDbContext<CookBookDbContext>(c =>
            {
                try
                {
                    string connectionString = builder.Configuration.GetValue<string>("DefaultConnection");
                    c.UseSqlServer(connectionString);
                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                }
            });

            builder.Services.AddScoped<IUnitOfWork, CookBookDbContext>();
            builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
            builder.Services.AddScoped<IRecipeService, RecipeService>();

            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }
}
