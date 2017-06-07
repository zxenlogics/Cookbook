using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public class DbInstance : BaseEntity
    {        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int DbEngineId { get; set; }
        [MaxLength(100)]
        public string DbEngine { get; set; }
        public int ServerId { get; set; }

        public virtual ICollection<Database> Databases { get; set; }    
        public virtual Server Server { get; set; }
        //public virtual DBEngine DBEngine { get; set; }
    }
}
