using CookBook.Domain;

namespace CookBook.Api.Dto
{
    public static class RecipeDtoExtension
    {
        public static Recipe ConvertToRecipe(this RecipeDto recipe)
        {
            return new Recipe
            {
                Id = recipe.Id,
                Title = recipe.Title,
                Description = recipe.Description,
                CookingTime = recipe.CookingTime,
                Portions = recipe.Portions,
                Stars = recipe.Stars,
                Likes = recipe.Likes
    };
        }

        public static RecipeDto ConvertToRecipeDto(this Recipe recipeDto)
        {
            return new RecipeDto
            {
                Id = recipeDto.Id,
                Title = recipeDto.Title,
                Description = recipeDto.Description,
                CookingTime = recipeDto.CookingTime,
                Portions = recipeDto.Portions,
                Stars = recipeDto.Stars,
                Likes = recipeDto.Likes
            };
        }

    }
}
