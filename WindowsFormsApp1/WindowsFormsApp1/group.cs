//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public group()
        {
            this.students = new HashSet<students>();
        }
    
        public int id_group { get; set; }
        public string name { get; set; }
        public Nullable<int> id_office { get; set; }
        public Nullable<int> status_group { get; set; }
        public string headman { get; set; }
        public string class_headman { get; set; }
        public Nullable<int> number_students { get; set; }
    
        public virtual otdelenie otdelenie { get; set; }
        public virtual status_group status_group1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students> students { get; set; }
    }
}
