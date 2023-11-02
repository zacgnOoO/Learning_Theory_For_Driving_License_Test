using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Password { get; set; }

    public string? RoleId { get; set; }

    public virtual Staff? Staff { get; set; }

    public virtual Student? Student { get; set; }
}
