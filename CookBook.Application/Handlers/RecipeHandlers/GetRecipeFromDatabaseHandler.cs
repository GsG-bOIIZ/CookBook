using CookBook.Domain.Recipe;

namespace CookBook.Application.Handlers
{
    public class GetRecipeFromDatabaseHandler : IGetRecipeFromDatabaseHandler
    {
        private readonly IRecipeService _recipeService;

        public GetRecipeFromDatabaseHandler(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public Recipe Handle(int recipeId)
        {
            return _recipeService.GetRecipe(recipeId);
        }
    }
}
