using CookBook.Domain;

namespace CookBook.Infrastructure.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly CookBookDbContext _dbContext;
        public RecipeRepository(CookBookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Recipe> GetRecipes()
        {
            return _dbContext.Recipe.ToList();
        }
        public Recipe GetById(int id)
        {
            return _dbContext.Recipe.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Recipe recipe)
        {
            _dbContext.Recipe.Add(recipe);
        }
        public void Delete(Recipe recipe)
        {
            _dbContext.Recipe.Remove(recipe);
        }
        public void Update(Recipe recipe)
        {
            _dbContext.Recipe.Update(recipe);
        }

    }
}