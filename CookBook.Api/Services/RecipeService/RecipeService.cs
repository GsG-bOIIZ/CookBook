using CookBook.Domain;
using CookBook.Api.Dto;
using CookBook.Infrastructure.UoW;
using CookBook.Infrastructure.Repository;

namespace CookBook.Api.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IRecipeRepository recipeRepository, IUnitOfWork unitOfWork)
        {
            _recipeRepository = recipeRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Recipe> GetRecipes()
        {
            return _recipeRepository.GetRecipes();
        }

        public void CreateRecipe(RecipeDto recipe)
        {
            if (recipe == null)
            {
                throw new Exception($"{nameof(recipe)} not found");
            }

            Recipe recipeEntity = recipe.ConvertToRecipe();

            _recipeRepository.Create(recipeEntity);
            _unitOfWork.SaveChanges();

        }

        public void DeleteRecipe(int recipeId)
        {
            Recipe recipe = _recipeRepository.GetById(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(recipe)} not found, #Id - {recipeId}");
            }

            _recipeRepository.Delete(recipe);
            _unitOfWork.SaveChanges();
        }

        public Recipe GetRecipe(int recipeId)
        {
            Recipe recipe = _recipeRepository.GetById(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(recipe)} not found, #Id - {recipeId}");
            }

            return recipe;
        }

        public void UpdateRecipe(RecipeDto recipeDto)
        {
            if (recipeDto == null)
            {
                throw new Exception($"{nameof(recipeDto)} not found");
            }

            Recipe facultyEntity = recipeDto.ConvertToRecipe();

            _recipeRepository.Update(facultyEntity);
            _unitOfWork.SaveChanges();
        }

    }
}
