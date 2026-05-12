using System;
using System.Collections.Generic;

namespace Wk2_1_Razor_DbFirst.Models;

public partial class Student1
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? GradeGradeId { get; set; }

    public virtual Grade? GradeGrade { get; set; }
}
