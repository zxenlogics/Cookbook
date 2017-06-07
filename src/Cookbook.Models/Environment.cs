using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public partial class Environment : BaseEntity
    {        
        // TODO: Interim: Name will be a calculated field based on {EnvironmentType + Id}
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsCluster { get; set; }
        [MaxLength(15)]
        public string State { get; set; }
        [MaxLength(15)]
        public string CurrentVersion { get; set; }
        [MaxLength(15)]
        public string TargetVersion { get; set; }
        [MaxLength(150)]
        public string Notes { get; set; }
        public DateTime LastUpdated { get; set; }
        public int ClientId { get; set; }                 
        public int EnvironmentTypeId { get; set; }
        public int ProjectId { get; set; }
           
        public virtual ICollection<Server> Servers { get; set; }
        public virtual EnvironmentType EnvironmentType { get; set; }
        public virtual Client Client { get; set; }    
        public virtual Project Project { get; set; }
        //public ICollection<EnvironmentDatabase> Databases { get; set; }
    }
}
