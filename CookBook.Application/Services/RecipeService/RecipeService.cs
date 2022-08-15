using CookBook.Domain;
using CookBook.Application.Dto;

namespace CookBook.Application
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IRecipeDtoConverter _recipeDtoConverter;

        public RecipeService(IRecipeRepository recipeRepository, IRecipeDtoConverter recipeDtoConverter)
        {
            _recipeRepository = recipeRepository;
            _recipeDtoConverter = recipeDtoConverter;
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

            Recipe recipeEntity = _recipeDtoConverter.ConvertToRecipe(recipe);

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

            Recipe recipeEntity = _recipeDtoConverter.ConvertToRecipe(recipeDto);
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
