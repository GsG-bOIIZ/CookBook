using CookBook.Api.Dto;
using CookBook.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookBook.Api.Controllers
{
    [ApiController]
    [Route("api/recipe")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetRecipes()
        {
            try
            {
                return Ok(_recipeService.GetRecipes()
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
                return Ok(_recipeService.GetRecipe(recipeId).ConvertToRecipeDto());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateFaculty([FromBody] RecipeDto recipe)
        {
            try
            {
                _recipeService.CreateRecipe(recipe);
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
                _recipeService.DeleteRecipe(recipeId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateFaculty([FromBody] RecipeDto recipe)
        {
            try
            {
                _recipeService.UpdateRecipe(recipe);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
