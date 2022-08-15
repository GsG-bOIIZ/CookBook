namespace CookBook.Application.Handlers
{
    public interface IDeleteRecipeAndStoreInDatabaseHandler
    {
        public void Handle(int recipeId);
    }
}
