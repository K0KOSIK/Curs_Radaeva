using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string NameRole { get; set; } = null!;

    public virtual ICollection<Avtorizacium> Avtorizacia { get; set; } = new List<Avtorizacium>();
}
