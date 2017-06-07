using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class User : BaseEntity
    {   
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string VstsGuid { get; set; }

        // Navigation Properties
        //public Team Team { get; set; }
    }
}
