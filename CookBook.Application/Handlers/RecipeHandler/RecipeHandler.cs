using CookBook.Application.Dto;
using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public class RecipeHandler : IRecipeHandler
    {
        private readonly IRecipeService _recipeService;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeHandler(IRecipeService recipeService, IUnitOfWork unitOfWork)
        {
            _recipeService = recipeService;
            _unitOfWork = unitOfWork;
        }

        public List<Recipe> GetRecipesFromDatabase()
        {
            return _recipeService.GetRecipes();
        }

        public Recipe GetRecipeFromDatabase(int recipeId)
        {
            return _recipeService.GetRecipe(recipeId);
        }

        public void CreateRecipeAndStoreInDatabase(RecipeDto recipe)
        {
            _recipeService.CreateRecipe(recipe);
            _unitOfWork.SaveChanges();
        }

        public void DeleteRecipeAndStoreInDatabase(int recipeId)
        {
            _recipeService.DeleteRecipe(recipeId);
            _unitOfWork.SaveChanges();
        }

        public void UpdateRecipeAndStoreInDatabase(RecipeDto recipe)
        {
            _recipeService.UpdateRecipe(recipe);
            _unitOfWork.SaveChanges();
        }
    }
}
