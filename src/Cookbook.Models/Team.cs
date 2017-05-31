using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Team : BaseEntity
    {        
        [Required]
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
