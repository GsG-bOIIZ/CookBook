using CookBook.Application.Dto;
using Microsoft.AspNetCore.Mvc;
using CookBook.Application.Handlers;

namespace CookBook.Api.Controllers
{
    [ApiController]
    [Route("api/recipe")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeHandler _recipeHandler;

        public RecipeController(IRecipeHandler recipeHandler)
        {
            _recipeHandler = recipeHandler;
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetRecipes()
        {
            try
            {
                return Ok(_recipeHandler.GetRecipesFromDatabase()
                    .ConvertAll(t => t.ConvertToRecipeDto()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{recipeId}")]
        public IActionResult GetRecipe(int recipeId)
        {
            try
            {
                return Ok(_recipeHandler.GetRecipeFromDatabase(recipeId).ConvertToRecipeDto());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateRecipe([FromBody] RecipeDto recipe)
        {
            try
            {
                _recipeHandler.CreateRecipeAndStoreInDatabase(recipe);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{recipeId}/delete")]
        public IActionResult DeleteRecipe(int recipeId)
        {
            try
            {
                _recipeHandler.DeleteRecipeAndStoreInDatabase(recipeId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateRecipe([FromBody] RecipeDto recipe)
        {
            try
            {
                _recipeHandler.UpdateRecipeAndStoreInDatabase(recipe);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
