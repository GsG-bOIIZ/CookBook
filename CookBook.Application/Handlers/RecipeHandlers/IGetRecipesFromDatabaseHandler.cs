using CookBook.Domain.Recipe;

namespace CookBook.Application.Handlers
{
    public interface IGetRecipesFromDatabaseHandler
    {
        public List<Recipe> Handle();
    }
}
