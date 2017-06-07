using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Branch : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
