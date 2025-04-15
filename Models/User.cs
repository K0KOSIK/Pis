using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class User
{
    public int IdUsers { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
