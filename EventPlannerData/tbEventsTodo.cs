//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventPlannerData
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEventsTodo
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public Nullable<int> EventId { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<bool> IsPending { get; set; }
    }
}
