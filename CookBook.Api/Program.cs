using CookBook.Application;
using CookBook.Application.Dto;
using CookBook.Application.Handlers;
using CookBook.Domain;
using CookBook.Infrastructure;
using CookBook.Infrastructure.Repository;
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

            builder.Services.AddScoped<IUnitOfWork>(sp => sp.GetService<CookBookDbContext>());
            builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
            builder.Services.AddScoped<IRecipeService, RecipeService>();

            builder.Services.AddScoped<ICreateRecipeAndStoreInDatabaseHandler, CreateRecipeAndStoreInDatabaseHandler>();
            builder.Services.AddScoped<IDeleteRecipeAndStoreInDatabaseHandler, DeleteRecipeAndStoreInDatabaseHandler>();
            builder.Services.AddScoped<IGetRecipeFromDatabaseHandler, GetRecipeFromDatabaseHandler>();
            builder.Services.AddScoped<IGetRecipesFromDatabaseHandler, GetRecipesFromDatabaseHandler>();
            builder.Services.AddScoped<IUpdateRecipeAndStoreInDatabaseHandler, UpdateRecipeAndStoreInDatabaseHandler>();

            builder.Services.AddScoped<IRecipeDtoConverter, RecipeDtoConverter>();

            var app = builder.Build();
            app.MapControllers();
            app.Run();
        }
    }
}
