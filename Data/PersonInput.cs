namespace Recipes_Api.Data
{
	public class PersonInput
	{
		public int? Id { get; set; }

		public string Name { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public int Age { get; set; }

		public string Email { get; set; } = null!;
	}
}
