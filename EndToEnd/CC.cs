//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EndToEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CC()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int CCID { get; set; }
        [Display(Name = "Category Name")]
        [StringLength(20, ErrorMessage = "The name must be under 20 characters.")]
        public string CCName { get; set; }
        [Display(Name = "Category Description")]
        [StringLength(20, ErrorMessage = "The description must be under 20 characters.")]
        public string CCDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
