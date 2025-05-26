using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string NameAdmin { get; set; } = null!;

    public long TelAdmin { get; set; }

    public int? IdAuthorization { get; set; }

    public virtual Authorization? IdAuthorizationNavigation { get; set; }
}
