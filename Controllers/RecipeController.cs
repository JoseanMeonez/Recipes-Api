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
			return Ok(recipes);
		}

		// GET api/<RecipeController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var recipe = new Recipe() { Id = id };
			var res = await _recipeRepository.GetOne(recipe.Id);
			return Ok(res);
		}

		// POST api/<RecipeController>
		[HttpPost]
		public async Task<ActionResult<Recipe>> Create([FromBody]RecipeInput data)
		{
			var recipe = new Recipe()
			{
				Title = data.Title,
				Description = data.Description,
				DateCreated = data.DateCreated,
				PersonId = data.PersonId
			};
			await _recipeRepository.Create(recipe);
			return Created(string.Empty, recipe.Id);
		}

		// PUT api/<RecipeController>/5
		[HttpPut]
		public async Task<ActionResult<Recipe>> Put([FromBody] RecipeInput data)
		{
			// Verifyng that all of the model's attributes are sended
      if (ModelState.IsValid) {
				// Verifyng Id
				if (data.Id != null) {
					// Filling recipe's data
					var recipe = new Recipe()
					{
						Id = (int)data.Id,
						Title = data.Title,
						Description = data.Description,
						DateCreated = data.DateCreated,
						PersonId = data.PersonId
					};

					var response = await _recipeRepository.Update(recipe);
					return Ok(response);
				} else {
					return BadRequest("No se pasó el ID de la receta para actualzarla.");
				}       
      } else {
				return BadRequest("Uno o más campos ingresados son nulos o no se enviaron, por favor asergurate que todos lo campos lleven su valor correspondiente.");
			}

		}

		// DELETE api/<RecipeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			
		}
	}
}
