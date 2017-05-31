using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public partial class Environment : BaseEntity
    {        
        //public Environment()
        //{
        //    Databases = new HashSet<Database>();
        //    Servers = new HashSet<Server>();
        //}

        [Required]
        public string Name { get; set; }
        public bool IsCluster { get; set; }
        public int ClientId { get; set; }                 
        public int EnvironmentTypeId { get; set; }

        //public virtual ICollection<Database> Databases { get; set; }        
        public virtual ICollection<Server> Servers { get; set; }
        public virtual EnvironmentType EnvironmentType { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
