using CookBook.Domain.Recipe;

namespace CookBook.Application.Dto
{
    public class RecipeDtoConverter : IRecipeDtoConverter
    {
        public Recipe ConvertToRecipe(RecipeDto recipe)
        {
            return new Recipe
            {
                Id = recipe.Id,
                Title = recipe.Title,
                Description = recipe.Description,
                CookingTime = recipe.CookingTime,
                Portions = recipe.Portions,
                /*Stars = recipe.Stars,
                Likes = recipe.Likes*/
            };
        }

        public RecipeDto ConvertToRecipeDto(Recipe recipeDto)
        {
            return new RecipeDto
            {
                Id = recipeDto.Id,
                Title = recipeDto.Title,
                Description = recipeDto.Description,
                CookingTime = recipeDto.CookingTime,
                Portions = recipeDto.Portions,
                /*Stars = recipeDto.Stars,
                Likes = recipeDto.Likes*/
            };
        }
    }
}
