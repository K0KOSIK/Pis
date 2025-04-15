using System;
using System.Collections.Generic;

namespace Pis.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string Role1 { get; set; } = null!;

    public int UsersIdUsers { get; set; }

    public virtual User UsersIdUsersNavigation { get; set; } = null!;
}
