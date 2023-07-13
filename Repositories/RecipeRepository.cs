using Microsoft.EntityFrameworkCore;
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

		public Task<Recipe> GetOne(int id)
		{
			return _recipesContext.Recipes.FirstOrDefaultAsync(a => a.Id.Equals(id));
		}

		public async Task<IEnumerable<Recipe>> GetAll()
		{
			return await _recipesContext.Recipes.ToListAsync();
		}

		public async Task<Recipe> Create(Recipe recipe)
		{
			var res = _recipesContext.Add(recipe);
			await _recipesContext.SaveChangesAsync();
			return res.Entity;
		}

		public async Task<Recipe> Update(Recipe recipe)
		{
			var res = _recipesContext.Recipes.Update(recipe);
			await _recipesContext.SaveChangesAsync();
			return res.Entity;
		}

		public async Task Delete(int id)
		{
			//var recipe = new Recipe() { Id = id };
			//_recipesContext.Recipes.Remove(recipe);
			//await _recipesContext.SaveChangesAsync();
			throw new NotImplementedException();
		}

	}
}
