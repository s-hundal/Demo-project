using System;
using System.Collections.Generic;

namespace Wk2_1_Razor_DbFirst.Models;

public partial class ViewStudentCourse
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int CourseId { get; set; }

    public string? CourseName { get; set; }
}
