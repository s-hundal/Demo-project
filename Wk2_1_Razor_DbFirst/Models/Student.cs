  using System;
using System.Collections.Generic;

namespace Wk2_1_Razor_DbFirst.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int? StandardId { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual Standard? Standard { get; set; }

    public virtual StudentAddress? StudentAddress { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
