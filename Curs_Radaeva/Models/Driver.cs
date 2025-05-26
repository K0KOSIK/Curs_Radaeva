using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Driver
{
    public int IdDrivers { get; set; }

    public string NameDrivers { get; set; } = null!;

    public int LicenseNumberDrivers { get; set; }

    public long TelDrivers { get; set; }

    public int IdStatusDrivers { get; set; }

    public int? IdAuthorization { get; set; }

    public virtual Authorization? IdAuthorizationNavigation { get; set; }

    public virtual StatusDriver IdStatusDriversNavigation { get; set; } = null!;

    public virtual ICollection<TimeTable> TimeTables { get; set; } = new List<TimeTable>();
}
