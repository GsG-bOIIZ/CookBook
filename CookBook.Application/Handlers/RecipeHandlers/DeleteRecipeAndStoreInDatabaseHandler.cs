using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public class DeleteRecipeAndStoreInDatabaseHandler : IDeleteRecipeAndStoreInDatabaseHandler
    {
        private readonly IRecipeService _recipeService;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRecipeAndStoreInDatabaseHandler(IRecipeService recipeService, IUnitOfWork unitOfWork)
        {
            _recipeService = recipeService;
            _unitOfWork = unitOfWork;
        }

        public void Handle(int recipeId)
        {
            _recipeService.DeleteRecipe(recipeId);
            _unitOfWork.SaveChanges();
        }
    }
}
