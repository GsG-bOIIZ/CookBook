using CookBook.Domain.Recipe;

namespace CookBook.Application.Handlers
{
    public interface IGetRecipeFromDatabaseHandler
    {
        public Recipe Handle(int recipeId);
    }
}
