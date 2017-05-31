using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class EnvironmentType : BaseEntity
    {        
        //public EnvironmentType()
        //{
        //    Environments = new HashSet<Environment>();
        //}

        [Required]
        public string Name { get; set; }
        
        //public virtual ICollection<Environment> Environments { get; set; }
    }
}
