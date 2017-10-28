//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreOTAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            this.NEW_RID_TABLE = new HashSet<NEW_RID_TABLE>();
            this.NewElectivesTables = new HashSet<NewElectivesTable>();
            this.Suggestions = new HashSet<Suggestion>();
        }
    
        public string USN { get; set; }
        public string NAME { get; set; }
        public string DOB { get; set; }
        public string FATHERNAME { get; set; }
        public string MOTHERNAME { get; set; }
        public string GUARDIANNAME { get; set; }
        public string PERM_ADDRESS { get; set; }
        public string LOC_ADDRESS { get; set; }
        public string MOBILE { get; set; }
        public string PRIMARY_CONTACT { get; set; }
        public string DeptID { get; set; }
        public Nullable<int> Sem { get; set; }
        public string Section { get; set; }
        public string EMail { get; set; }
        public Nullable<decimal> SSLC { get; set; }
        public Nullable<decimal> PUC { get; set; }
        public Nullable<int> Batch { get; set; }
        public Nullable<bool> isVallid { get; set; }
        public string Password { get; set; }
    
        public virtual DEPT DEPT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NEW_RID_TABLE> NEW_RID_TABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewElectivesTable> NewElectivesTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suggestion> Suggestions { get; set; }
        public virtual Valid Valid { get; set; }
    }
}
