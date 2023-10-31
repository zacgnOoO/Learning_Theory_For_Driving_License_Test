using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Question
{
    public string QuestionId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public string? Question1 { get; set; }

    public string? ImageUrl { get; set; }

    public string? Answers1 { get; set; }

    public string? Answers2 { get; set; }

    public string? Answers3 { get; set; }

    public string? Answers4 { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<SampleTest> SampleTests { get; set; } = new List<SampleTest>();

    public virtual ICollection<TestAnswer> TestAnswers { get; set; } = new List<TestAnswer>();
}
