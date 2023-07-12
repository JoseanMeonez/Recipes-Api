using Recipes_Api.Data;

namespace Recipes_Api.Repositories
{
	public interface IPersonRepository
	{
		Task<Person> GetPerson(int id);

		Task<IEnumerable<Person>> GetPeople();

		Task<Person> Create(Person person);

		Task Update(Person person);

		Task Delete(int id);
	}
}
