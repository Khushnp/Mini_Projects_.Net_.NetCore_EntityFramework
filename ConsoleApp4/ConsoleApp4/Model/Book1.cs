using System;
using System.Collections.Generic;

namespace ConsoleApp4.Model;

public partial class Book1
{
    public long Id { get; set; }

    public DateTime AddedDate { get; set; }

    public long AuthorId { get; set; }

    public int Ipaddress { get; set; }

    public long? Isbn { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? Name { get; set; }

    public string Publisher { get; set; } = null!;

    public virtual Author1 Author { get; set; } = null!;
}
