﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class SampleTest
{
    public string SampleTestId { get; set; } = null!;

    public int? TotalQuestion { get; set; }

    public int? CorrectAnswer { get; set; }

    public int? IsChoosen { get; set; }
}
