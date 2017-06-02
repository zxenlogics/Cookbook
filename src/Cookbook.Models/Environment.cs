using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public partial class Environment : BaseEntity
    {        
        [Required]
        public string Name { get; set; }
        public bool IsCluster { get; set; }
        public string State { get; set; }
        public string CurrentVersion { get; set; }
        public string TargetVersion { get; set; }
        public string Notes { get; set; }
        public DateTime LastUpdated { get; set; }
        public int ClientId { get; set; }                 
        public int EnvironmentTypeId { get; set; }

        //public virtual ICollection<Database> Databases { get; set; }        
        public virtual ICollection<Server> Servers { get; set; }
        public virtual EnvironmentType EnvironmentType { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
