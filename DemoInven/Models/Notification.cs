//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoInven.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int Id { get; set; }
        public string NotificationDetail { get; set; }
        public Nullable<System.DateTime> GeneratedOn { get; set; }
        public Nullable<bool> IsOpened { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    
        public virtual NotificationStatus NotificationStatus { get; set; }
    }
}
