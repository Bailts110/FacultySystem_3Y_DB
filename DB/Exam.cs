//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacultySystem_3Y_DB.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int Id { get; set; }
        public Nullable<int> Course_ID { get; set; }
        public string Exam_Type { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
    
        public virtual Cours Cours { get; set; }
    }
}
