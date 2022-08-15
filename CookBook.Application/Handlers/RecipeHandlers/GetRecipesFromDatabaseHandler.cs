using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public class GetRecipesFromDatabaseHandler : IGetRecipesFromDatabaseHandler
    {
        private readonly IRecipeService _recipeService;

        public GetRecipesFromDatabaseHandler(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public List<Recipe> Handle()
        {
            return _recipeService.GetRecipes();
        }
    }
}
