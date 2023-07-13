namespace Recipes_Api.Data;

public class Recipe
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;
}
