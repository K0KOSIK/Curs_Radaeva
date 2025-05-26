using System;
using System.Collections.Generic;

namespace Curs_Radaeva.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public string NameClient { get; set; } = null!;

    public long TelClient { get; set; }

    public DateOnly DataRegisteredClient { get; set; }

    public int? IdAvtorizacia { get; set; }

    public virtual Avtorizacium? IdAvtorizaciaNavigation { get; set; }
}
