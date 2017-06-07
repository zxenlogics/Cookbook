using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Project : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(20)]
        public string ProjectType { get; set; }
        public int BranchId { get; set; }
        public int EnvironmentId { get; set; }

        // Navigation Properties.        
        public virtual ICollection<Team> Teams { get; set; }        
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Environment> Environments { get; set; }
    }
}
