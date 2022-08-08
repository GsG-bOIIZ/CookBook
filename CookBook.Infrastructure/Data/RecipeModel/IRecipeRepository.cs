using CookBook.Domain;

namespace CookBook.Infrastructure.Repository
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
