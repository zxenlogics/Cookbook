using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class Database : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int DbInstanceId { get; set; }
        public int EnvironmentDatabaseId { get; set; }

        public virtual DbInstance DbInstance { get; set; }   
        public virtual EnvironmentDatabase Environment { get; set; }
    }
}
