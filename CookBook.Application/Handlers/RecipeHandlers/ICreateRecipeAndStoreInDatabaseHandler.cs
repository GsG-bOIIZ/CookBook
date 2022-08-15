using CookBook.Application.Dto;

namespace CookBook.Application.Handlers
{
    public interface ICreateRecipeAndStoreInDatabaseHandler
    {
        public void Handle(RecipeDto recipe);
    }
}
