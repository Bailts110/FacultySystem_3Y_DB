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
    
    public partial class Faculty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Department_ID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Position { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
