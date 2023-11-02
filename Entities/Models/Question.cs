using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? CategoryId { get; set; }

    public string? Question1 { get; set; }

    public string? ImageUrl { get; set; }

    public string? Answers1 { get; set; }

    public string? Answers2 { get; set; }

    public string? Answers3 { get; set; }

    public string? Answers4 { get; set; }

    public string? CorrectAnswer { get; set; }

    public virtual Category? Category { get; set; }
}
