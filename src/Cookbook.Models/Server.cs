using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public class Server : BaseEntity
    {        
        [Required]
        [MaxLength(100)]
        public string Hostname { get; set; }
        [Required]
        [MaxLength(45)]
        public string IP { get; set; }
        [MaxLength(15)]
        public string State { get; set; }
        public int DomainId { get; set; }
        public int EnvironmentId { get; set; }
        
        //public virtual ICollection<DBEngine> DBEngines { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Environment Environment { get; set; }       
        public virtual ICollection<ServerRole> ServerRoles { get; set; }
    }
}
