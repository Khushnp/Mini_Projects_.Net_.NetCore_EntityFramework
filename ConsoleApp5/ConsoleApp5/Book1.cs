//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book1
    {
        public long id { get; set; }
        public System.DateTime AddedDate { get; set; }
        public long AuthorId { get; set; }
        public int IPAddress { get; set; }
        public Nullable<long> ISBN { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
    
        public virtual Author1 Author1 { get; set; }
    }
}
