using CookBook.Application.Dto;

namespace CookBook.Application.Handlers
{
    public interface IUpdateRecipeAndStoreInDatabaseHandler
    {
        public void Handle(RecipeDto recipe);
    }
}
