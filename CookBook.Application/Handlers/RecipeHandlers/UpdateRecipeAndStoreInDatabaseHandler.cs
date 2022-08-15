using CookBook.Application.Dto;
using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public class UpdateRecipeAndStoreInDatabaseHandler : IUpdateRecipeAndStoreInDatabaseHandler
    {
        private readonly IRecipeService _recipeService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRecipeAndStoreInDatabaseHandler(IRecipeService recipeService, IUnitOfWork unitOfWork)
        {
            _recipeService = recipeService;
            _unitOfWork = unitOfWork;
        }

        public void Handle(RecipeDto recipe)
        {
            _recipeService.UpdateRecipe(recipe);
            _unitOfWork.SaveChanges();
        }
    }
}
