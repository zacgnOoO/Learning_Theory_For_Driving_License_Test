using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SampleTest
{
    public string SampleTestId { get; set; } = null!;

    public string? QuestionId { get; set; }

    public virtual Question? Question { get; set; }

    public virtual StudentTest? StudentTest { get; set; }
}
