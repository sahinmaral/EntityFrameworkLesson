//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityOrnek
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades
    {
        public int GradeId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<short> Exam1 { get; set; }
        public Nullable<short> Exam2 { get; set; }
        public Nullable<short> Exam3 { get; set; }
        public Nullable<decimal> AverageGrade { get; set; }
        public Nullable<bool> isPassed { get; set; }
    
        public virtual Lessons Lessons { get; set; }
        public virtual Students Students { get; set; }
    }
}
