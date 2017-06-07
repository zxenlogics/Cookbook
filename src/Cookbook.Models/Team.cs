using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Team : BaseEntity
    {        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string VstsGuid { get; set; }
        
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
