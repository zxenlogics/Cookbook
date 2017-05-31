using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class User : BaseEntity
    {   
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // Navigation Properties
        //public Team Team { get; set; }
    }
}
