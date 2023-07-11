using Microsoft.AspNetCore.Mvc;
using Recipes_Api.Data;
using Recipes_Api.Repositories;

namespace Recipes_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecipeController : ControllerBase
	{
		private readonly IRecipeRepository _recipeRepository;

		public RecipeController(IRecipeRepository recipeRepository)
    {
			_recipeRepository = recipeRepository;
    }

    // GET: api/<RecipeController>
    [HttpGet]
		public async Task<IActionResult> Get()
		{
			var recipes = await _recipeRepository.GetAll();
			return Ok();
		}

		// GET api/<RecipeController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<RecipeController>
		[HttpPost]
		public async Task<ActionResult<Recipe>> Create(Recipe recipe)
		{
			var data = new Recipe()
			{
				Title = recipe.Title,
				Description = recipe.Description,
				DateCreated = recipe.DateCreated,
				PersonId = recipe.PersonId
			};
			await _recipeRepository.Create(data);
			return Created(string.Empty, recipe.Id);
		}

		// PUT api/<RecipeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			throw new NotImplementedException();
		}

		// DELETE api/<RecipeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
