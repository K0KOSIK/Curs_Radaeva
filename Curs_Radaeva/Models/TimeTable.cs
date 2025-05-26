using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class TimeTable
{
    public int IdTimeTable { get; set; }

    public int IdRoutes { get; set; }

    public int IdTransport { get; set; }

    public int IdDrivers { get; set; }

    public TimeOnly DepartureTime { get; set; }

    public TimeOnly ArrivalTime { get; set; }

    public virtual Driver Driver { get; set; } = null!;

    public virtual Route Route { get; set; } = null!;

    public virtual Transport Transport { get; set; } = null!;
}
