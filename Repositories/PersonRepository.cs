using Microsoft.EntityFrameworkCore;
using Recipes_Api.Data;

namespace Recipes_Api.Repositories
{
	public class PersonRepository : IPersonRepository
	{
		private readonly RecipesContext _recipesContext;

		public PersonRepository(RecipesContext recipesContext)
		{
			_recipesContext = recipesContext;
		}
		public Task<Person> Create(Person person)
		{
			throw new NotImplementedException();
		}

		public Task Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Person>> GetPeople()
		{
			return await _recipesContext.People.ToListAsync();
		}

		public Task<Person> GetPerson()
		{
			throw new NotImplementedException();
		}

		public Task Update(Person person)
		{
			throw new NotImplementedException();
		}
	}
}
