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
    
    public partial class Company_Profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company_Profiles()
        {
            this.Company_Descriptions = new HashSet<Company_Descriptions>();
            this.Company_Jobs = new HashSet<Company_Jobs>();
            this.Company_Locations = new HashSet<Company_Locations>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime Registration_Date { get; set; }
        public string Company_Website { get; set; }
        public string Contact_Phone { get; set; }
        public string Contact_Name { get; set; }
        public byte[] Company_Logo { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_Descriptions> Company_Descriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_Jobs> Company_Jobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_Locations> Company_Locations { get; set; }
    }
}
