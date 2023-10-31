using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Staff
{
    public string StaffId { get; set; } = null!;

    public string? RoleId { get; set; }

    public string? StaffName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual User StaffNavigation { get; set; } = null!;
}
