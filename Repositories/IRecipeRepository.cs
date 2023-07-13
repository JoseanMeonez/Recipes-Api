using Recipes_Api.Data;

namespace Recipes_Api.Repositories
{
	public interface IRecipeRepository
	{
		// Get an unique recipe
		Task<Recipe> GetOne(int id);

		// Get all the recipes on the DB
		Task<IEnumerable<Recipe>> GetAll();

		// Create a new recipe
		Task<Recipe> Create(Recipe recipe);

		// Update a recipe
		Task<Recipe> Update(Recipe recipe);

		// Delete a recipe
		Task Delete(int id);
	}
}
