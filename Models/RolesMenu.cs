//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcExamTaskMitRao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolesMenu
    {
        public int id { get; set; }
        public Nullable<int> roleId { get; set; }
        public Nullable<int> menuId { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
    }
}
