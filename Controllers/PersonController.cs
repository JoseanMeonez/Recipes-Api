using Microsoft.AspNetCore.Mvc;
using Recipes_Api.Data;
using Recipes_Api.Repositories;

namespace Recipes_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private readonly IPersonRepository _personRepository;

    public PersonController(IPersonRepository personRepository)
    {
			_personRepository = personRepository;
    }

	  // GET: api/<PersonController>
    [HttpGet]
		public async Task<IActionResult> Get()
		{
			var people = await _personRepository.GetPeople();
			return Ok(people);
		}

		// GET api/<PersonController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var person = new Person() { Id = id };
			var res = await _personRepository.GetPerson(person.Id);
			return Ok(res);
		}

		// POST api/<PersonController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
			throw new NotImplementedException();
		}

		// PUT api/<PersonController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			throw new NotImplementedException();
		}

		// DELETE api/<PersonController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
