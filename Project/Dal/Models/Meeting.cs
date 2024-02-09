using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Meeting
{
    public int Code { get; set; }

    public int DieticanId { get; set; }

    public int ClientsId { get; set; }

    public DateTime? Datetime { get; set; }

    public virtual Client Clients { get; set; } = null!;

    public virtual Dietitian Dietican { get; set; } = null!;
}
