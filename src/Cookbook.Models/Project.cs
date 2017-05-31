using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Project : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        // Navigatin Properties.
        public virtual ICollection<Environment> Environments { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
