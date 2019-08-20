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

    public partial class Trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            this.Topics = new HashSet<Topic>();
        }
    
        public int TrainerID { get; set; }
        [Display(Name = "Trainer Name")]
        [StringLength(20, ErrorMessage = "The name must be under 20 characters.")]
        public string TrainerName { get; set; }
        [Display(Name = "Type")]
        [StringLength(7, ErrorMessage = "The type must be under 8 characters.")]
        public string TrainerType { get; set; }
        [Display(Name = "Education")]
        [StringLength(20, ErrorMessage = "The education must be under 20 characters.")]
        public string TrainerEducation { get; set; }
        [Display(Name = "Phone")]
        [Range(100000000, 999999999, ErrorMessage = "Value must be between 100000000 and 999999999.")]
        public int TrainerPhone { get; set; }
        [Display(Name = "Email")]
        [StringLength(20, ErrorMessage = "The email must be under 20 characters.")]
        public string TrainerEmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
