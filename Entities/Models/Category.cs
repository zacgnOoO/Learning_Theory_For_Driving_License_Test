using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Category
{
    public string CategoryId { get; set; } = null!;

    public string? CategoryType { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
