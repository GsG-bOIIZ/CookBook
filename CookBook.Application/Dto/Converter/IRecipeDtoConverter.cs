using CookBook.Domain.Recipe;

namespace CookBook.Application.Dto
{
    public interface IRecipeDtoConverter
    {
        public Recipe ConvertToRecipe(RecipeDto recipe);
        public RecipeDto ConvertToRecipeDto(Recipe recipeDto);
    }
}