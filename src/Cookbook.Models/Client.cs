using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(5)]
        public string Abbreviation { get; set; }
        
        //public virtual ICollection<Environment> Environments { get; set; }
    }
}
