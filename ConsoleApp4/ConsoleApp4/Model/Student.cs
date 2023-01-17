using System;
using System.Collections.Generic;

namespace ConsoleApp4.Model;

public partial class Student
{
    public long StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? RollNo { get; set; }

    public string? Address { get; set; }
}
