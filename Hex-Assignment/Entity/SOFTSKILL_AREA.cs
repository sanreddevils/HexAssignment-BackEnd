namespace Hex_Assignment.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOFTSKILL_AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOFTSKILL_AREA()
        {
            USER_SKILL_RATING = new HashSet<USER_SKILL_RATING>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(63)]
        public string SkillSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_SKILL_RATING> USER_SKILL_RATING { get; set; }
    }
}
