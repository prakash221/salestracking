//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfileDetail
    {
        public int ProfileDetailId { get; set; }
        public int ProfileId { get; set; }
        public int ModuleId { get; set; }
        public bool CreateStatus { get; set; }
        public bool EditStatus { get; set; }
        public bool DeleteStatus { get; set; }
        public bool PrintStatus { get; set; }
        public bool ViewStatus { get; set; }
    }
}