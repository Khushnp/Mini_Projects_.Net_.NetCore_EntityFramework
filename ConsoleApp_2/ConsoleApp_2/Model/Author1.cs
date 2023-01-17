using System;
using System.Collections.Generic;

namespace ConsoleApp_2.Model
{
    public partial class Author1
    {
        public long Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string? Email { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public int Ipaddress { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Book1? Book1 { get; set; }
    }
}
