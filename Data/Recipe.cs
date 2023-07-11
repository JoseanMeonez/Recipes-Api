using System;
using System.Collections.Generic;

namespace Recipes_Api.Data;

public partial class Recipe
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;
}
