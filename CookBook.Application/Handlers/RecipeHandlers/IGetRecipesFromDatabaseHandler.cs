using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public interface IGetRecipesFromDatabaseHandler
    {
        public List<Recipe> Handle();
    }
}
