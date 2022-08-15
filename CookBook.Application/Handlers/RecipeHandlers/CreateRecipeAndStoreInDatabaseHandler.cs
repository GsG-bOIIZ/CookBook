using CookBook.Application.Dto;
using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public class CreateRecipeAndStoreInDatabaseHandler : ICreateRecipeAndStoreInDatabaseHandler
    {
        private readonly IRecipeService _recipeService;
        private readonly IUnitOfWork _unitOfWork;

        public CreateRecipeAndStoreInDatabaseHandler(IRecipeService recipeService, IUnitOfWork unitOfWork)
        {
            _recipeService = recipeService;
            _unitOfWork = unitOfWork;
        }

        public void Handle(RecipeDto recipe)
        {
            _recipeService.CreateRecipe(recipe);
            _unitOfWork.SaveChanges();
        }
    }
}
