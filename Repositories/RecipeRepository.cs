using Recipes_Api.Data;

namespace Recipes_Api.Repositories
{
	public class RecipeRepository : IRecipeRepository
	{
		private readonly RecipesContext _recipesContext;

		public RecipeRepository(RecipesContext recipesContext)
    {
			_recipesContext = recipesContext;
		}

		public Task<Recipe> GetOne(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Recipe>> GetAll()
		{
			throw new NotImplementedException();
		}

		public async Task<Recipe> Create(Recipe recipe)
		{
			var res = _recipesContext.Add(recipe);
			await _recipesContext.SaveChangesAsync();
			return res.Entity;
		}

		public Task Update(Recipe recipe)
		{
			throw new NotImplementedException();
		}

		public async Task Delete(Guid id)
		{
			//var recipe = new Recipe() { Id = id };
			//_recipesContext.Recipes.Remove(recipe);
			//await _recipesContext.SaveChangesAsync();
			throw new NotImplementedException();
		}

	}
}
