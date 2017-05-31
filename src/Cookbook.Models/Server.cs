using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public class Server : BaseEntity
    {        
        //public Server()
        //{
        //    DBEngines = new HashSet<DBEngine>();
        //    ServerRoles = new HashSet<ServerRole>();
        //}

        [Required]
        public string Hostname { get; set; }
        [Required]
        public string IP { get; set; }
        public int DomainId { get; set; }
        public int EnvironmentId { get; set; }
        
        //public virtual ICollection<DBEngine> DBEngines { get; set; }
        public virtual Domain Domain { get; set; }
        public virtual Environment Environment { get; set; }       
        public virtual ICollection<ServerRole> ServerRoles { get; set; }
    }
}
