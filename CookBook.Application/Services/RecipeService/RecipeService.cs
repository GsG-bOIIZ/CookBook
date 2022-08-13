using CookBook.Domain;
using CookBook.Application.Dto;

namespace CookBook.Application
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
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

        }

        public void DeleteRecipe(int recipeId)
        {
            Recipe recipe = _recipeRepository.GetById(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(recipe)} not found, #Id - {recipeId}");
            }

            _recipeRepository.Delete(recipe);
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

            Recipe recipeEntity = recipeDto.ConvertToRecipe();
            Recipe recipeForUpdate = GetRecipe(recipeEntity.Id);

            if (recipeForUpdate.Title != recipeEntity.Title)
            {
                recipeForUpdate.Title = recipeEntity.Title;
            }

            if (recipeForUpdate.Description != recipeEntity.Description)
            {
                recipeForUpdate.Description = recipeEntity.Description;
            }

            if (recipeForUpdate.CookingTime != recipeEntity.CookingTime)
            {
                recipeForUpdate.CookingTime = recipeEntity.CookingTime;
            }

            if (recipeForUpdate.Portions != recipeEntity.Portions)
            {
                recipeForUpdate.Portions = recipeEntity.Portions;
            }

            _recipeRepository.Update(recipeForUpdate);
        }

    }
}
