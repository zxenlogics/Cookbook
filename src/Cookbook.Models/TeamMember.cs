using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class TeamMember : BaseEntity
    {
        [Required]
        public int TeamId { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public bool IsActive { get; set; }

        // Nav
        //public Team Team { get; set; }        
    }
}
