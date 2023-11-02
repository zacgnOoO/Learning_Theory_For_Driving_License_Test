using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class StudentTest
{
    public string? SampleTestId { get; set; }

    public string? StudentId { get; set; }

    public int? TotalCorrectAnwser { get; set; }

    public int? QuestionId { get; set; }

    public string? AnswerChoose { get; set; }

    public string? IsCorrect { get; set; }

    public virtual Question? Question { get; set; }

    public virtual SampleTest? SampleTest { get; set; }

    public virtual Student? Student { get; set; }
}
