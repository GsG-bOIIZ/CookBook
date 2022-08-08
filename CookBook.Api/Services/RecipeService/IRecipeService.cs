using CookBook.Domain;
using CookBook.Api.Dto;

namespace CookBook.Api.Services
{
    public interface IRecipeService
    {
        public List<Recipe> GetRecipes();
        public void CreateRecipe(RecipeDto recipe);
        public void DeleteRecipe(int recipeId);
        public Recipe GetRecipe(int recipeId);
        public void UpdateRecipe(RecipeDto recipeDto);
    }
}
