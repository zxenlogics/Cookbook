using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public class Domain : BaseEntity
    {        
        //public Domain()
        //{
        //    Servers = new HashSet<Server>();
        //}

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string DomainAbbreviation { get; set; }
        

        //public virtual ICollection<Server> Servers { get; set; }
    }
}
