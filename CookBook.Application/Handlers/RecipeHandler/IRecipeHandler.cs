using CookBook.Application.Dto;
using CookBook.Domain;

namespace CookBook.Application.Handlers
{
    public interface IRecipeHandler
    {
        public List<Recipe> GetRecipesFromDatabase();
        public Recipe GetRecipeFromDatabase(int recipeId);
        public void CreateRecipeAndStoreInDatabase(RecipeDto recipe);
        public void DeleteRecipeAndStoreInDatabase(int recipeId);
        public void UpdateRecipeAndStoreInDatabase(RecipeDto recipe);
    }
}
