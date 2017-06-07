using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Database : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int DbInstanceId { get; set; }

        public virtual DbInstance DbInstance { get; set; }        
    }
}
