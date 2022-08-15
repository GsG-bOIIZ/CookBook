using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public interface IGetRecipeFromDatabaseHandler
    {
        public Recipe Handle(int recipeId);
    }
}
