using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class QuestionSampleTest
{
    public int? QuestionId { get; set; }

    public string? SampleTestId { get; set; }

    public virtual Question? Question { get; set; }

    public virtual SampleTest? SampleTest { get; set; }
}
