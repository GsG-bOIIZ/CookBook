using CookBook.Application.Dto;
using Microsoft.AspNetCore.Mvc;
using CookBook.Application.Handlers;

namespace CookBook.Api.Controllers
{
    [ApiController]
    [Route("api/recipe")]
    public class RecipeController : ControllerBase
    {
        private readonly ICreateRecipeAndStoreInDatabaseHandler _recipeCreateHandler;
        private readonly IDeleteRecipeAndStoreInDatabaseHandler _recipeDeleteHandler;
        private readonly IGetRecipeFromDatabaseHandler _recipeGetRecipeHandler;
        private readonly IGetRecipesFromDatabaseHandler _recipeGetRecipesHandler;
        private readonly IUpdateRecipeAndStoreInDatabaseHandler _recipeUpdateHandler;
        private readonly IRecipeDtoConverter _recipeDtoConverter;

        public RecipeController(ICreateRecipeAndStoreInDatabaseHandler recipeCreateHandler,
                                IDeleteRecipeAndStoreInDatabaseHandler recipeDeleteHandler,
                                IGetRecipeFromDatabaseHandler recipeGetRecipeHandler,
                                IGetRecipesFromDatabaseHandler recipeGetRecipesHandler,
                                IUpdateRecipeAndStoreInDatabaseHandler recipeUpdateHandler,
                                IRecipeDtoConverter recipeDtoConverter)
        {
            _recipeCreateHandler = recipeCreateHandler;
            _recipeDeleteHandler = recipeDeleteHandler;
            _recipeGetRecipeHandler = recipeGetRecipeHandler;
            _recipeGetRecipesHandler = recipeGetRecipesHandler;
            _recipeUpdateHandler = recipeUpdateHandler;
            _recipeDtoConverter = recipeDtoConverter;
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetRecipes()
        {
            try
            {
                return Ok(_recipeGetRecipesHandler.Handle()
                    .ConvertAll(recipe => _recipeDtoConverter.ConvertToRecipeDto(recipe)));
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
                return Ok(_recipeDtoConverter.ConvertToRecipeDto(_recipeGetRecipeHandler.Handle(recipeId)));
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
                _recipeCreateHandler.Handle(recipe);
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
                _recipeDeleteHandler.Handle(recipeId);
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
                _recipeUpdateHandler.Handle(recipe);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
