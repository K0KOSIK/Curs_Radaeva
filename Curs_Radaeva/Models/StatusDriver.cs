using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class StatusDriver
{
    public int IdStatusDrivers { get; set; }

    public string NameStatusDrivers { get; set; } = null!;

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();
}
