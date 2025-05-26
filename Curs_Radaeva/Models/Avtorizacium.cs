using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Avtorizacium
{
    public int IdAvtorizacia { get; set; }

    public string LoginAvtorizacia { get; set; } = null!;

    public string PasswordAvtorizacia { get; set; } = null!;

    public int IdRole { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
