using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    //[Table("Databases")]
    public class Database : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int DBInstanceId { get; set; }
        //public int? EnvironmentId { get; set; }

        public virtual DBInstance DBInstance { get; set; }
        //public virtual Environment Environment { get; set; }
    }
}
