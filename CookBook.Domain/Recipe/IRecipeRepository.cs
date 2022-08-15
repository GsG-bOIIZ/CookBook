namespace CookBook.Domain
{
    public interface IRecipeRepository
    {
        public List<Recipe> GetRecipes();
        public Recipe GetById(int id);
        public void Create(Recipe recipe);
        public void Delete(Recipe recipe);
        public void Update(Recipe recipe);
    }
}
