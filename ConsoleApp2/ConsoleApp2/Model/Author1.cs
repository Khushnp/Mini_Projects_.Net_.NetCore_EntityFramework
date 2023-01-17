using System;
using System.Collections.Generic;

namespace ConsoleApp2.Model;

public partial class Author1
{
    public long Id { get; set; }

    public DateTime AddedDate { get; set; }

    public string? Email { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public int Ipaddress { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Book1> Book1s { get; } = new List<Book1>();
}
