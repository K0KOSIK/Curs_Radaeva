using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Transport
{
    public int IdTransport { get; set; }

    public string NumberplateTransport { get; set; } = null!;

    public decimal HeightTransport { get; set; }

    public decimal LongTransport { get; set; }

    public decimal WidthTransport { get; set; }

    public long MaxSpeedTransport { get; set; }

    public virtual ICollection<TimeTable> TimeTables { get; set; } = new List<TimeTable>();
}
