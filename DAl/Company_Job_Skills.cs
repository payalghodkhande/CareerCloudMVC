//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company_Job_Skills
    {
        public System.Guid Id { get; set; }
        public System.Guid Job { get; set; }
        public string Skill { get; set; }
        public string Skill_Level { get; set; }
        public int Importance { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        public virtual Company_Jobs Company_Jobs { get; set; }
    }
}
