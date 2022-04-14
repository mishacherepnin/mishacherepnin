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
    
    public partial class Врач
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Врач()
        {
            this.Расписание = new HashSet<Расписание>();
            this.Участок = new HashSet<Участок>();
        }
    
        public int id_врач { get; set; }
        public string фамилия_врач { get; set; }
        public string имя_врач { get; set; }
        public string отчество_врач { get; set; }
        public Nullable<int> возраст { get; set; }
        public Nullable<int> паспортые_данные { get; set; }
        public Nullable<int> id_категория { get; set; }
        public Nullable<int> id_кабинет { get; set; }
        public Nullable<int> id_специальность { get; set; }
    
        public virtual Кабинет Кабинет { get; set; }
        public virtual Категория Категория { get; set; }
        public virtual Специальность Специальность { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Расписание> Расписание { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Участок> Участок { get; set; }
    }
}
