using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class StudentTest
{
    public string SampleTestId { get; set; } = null!;

    public string? TestAnswerId { get; set; }

    public string? StudentId { get; set; }

    public virtual SampleTest SampleTest { get; set; } = null!;

    public virtual Student? Student { get; set; }

    public virtual TestAnswer? TestAnswer { get; set; }
}
