namespace Hex_Assignment.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_MASTER()
        {
          //  USER_SKILL_RATING = new HashSet<USER_SKILL_RATING>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(127)]
        public string Email { get; set; }

        [Required]
        [StringLength(127)]
        public string Password { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<USER_SKILL_RATING> USER_SKILL_RATING { get               
        //        ; set; }
    }
}
