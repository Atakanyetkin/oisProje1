//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ders()
        {
            this.tbl_ogrenciders = new HashSet<tbl_ogrenciders>();
        }
    
        public short ders_id { get; set; }
        public string ders_ad { get; set; }
        public string ders_kredi { get; set; }
        public Nullable<short> ders_okulyonetimid { get; set; }
    
        public virtual tbl_okulyonetim tbl_okulyonetim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ogrenciders> tbl_ogrenciders { get; set; }
    }
}
