using CookBook.Domain.Recipe;
using CookBook.Application.Dto;

namespace CookBook.Application
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
