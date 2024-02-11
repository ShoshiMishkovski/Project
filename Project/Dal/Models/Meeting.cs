using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Meeting
{
    public int Code { get; set; }

    public int DieticanId { get; set; }

    public int ClientsId { get; set; }

    public string? Status { get; set; }

    public DateTime? Date { get; set; }= DateTime.Now;

    public DateTime? Hour { get; set; }=DateTime.Now;

    public virtual Client Clients { get; set; } = null!;

    public virtual Dietitian Dietican { get; set; } = null!;
}
