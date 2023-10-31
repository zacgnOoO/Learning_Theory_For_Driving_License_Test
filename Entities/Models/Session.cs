using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Session
{
    public string SessionId { get; set; } = null!;

    public string? ScheduleId { get; set; }

    public TimeSpan? ThoiGian { get; set; }

    public DateTime? Day { get; set; }
}
