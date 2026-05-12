using System;
using System.Collections.Generic;

namespace Wk2_1_Razor_DbFirst.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public string? GradeName { get; set; }

    public virtual ICollection<Student1> Student1s { get; set; } = new List<Student1>();
}
