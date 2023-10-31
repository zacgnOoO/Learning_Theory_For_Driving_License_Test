using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TestAnswer
{
    public string TestAnswerId { get; set; } = null!;

    public string? QuestionId { get; set; }

    public string? CorrectAnswer { get; set; }

    public virtual Question? Question { get; set; }

    public virtual ICollection<StudentTest> StudentTests { get; set; } = new List<StudentTest>();
}
