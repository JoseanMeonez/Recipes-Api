using System.ComponentModel.DataAnnotations;

namespace Recipes_Api.Data
{
	public class RecipeInput
	{
		public int? Id { get; set; }

		[Required]
		public string Title { get; set; } = null!;

		[Required]
		public string Description { get; set; } = null!;

		[Required]
		public DateTime DateCreated { get; set; }

		[Required]
		public int PersonId { get; set; }
	}
}
