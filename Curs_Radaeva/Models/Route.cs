using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Route
{
    public int IdRoutes { get; set; }

    public string StartLocationRoutes { get; set; } = null!;

    public string EndLocationRoutes { get; set; } = null!;

    public int DistanceRoutes { get; set; }

    public TimeOnly TravelTimeRoutes { get; set; }

    public virtual ICollection<TimeTable> TimeTables { get; set; } = new List<TimeTable>();
}
