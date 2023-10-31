using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Student
{
    public string StudentId { get; set; } = null!;

    public string? RoleId { get; set; }

    public string? Address { get; set; }

    public string? StudentName { get; set; }

    public string? Phone { get; set; }

    public virtual User StudentNavigation { get; set; } = null!;

    public virtual ICollection<StudentTest> StudentTests { get; set; } = new List<StudentTest>();
}
