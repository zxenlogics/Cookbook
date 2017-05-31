using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public partial class DBInstance : BaseEntity
    {        
        //public DBInstance()
        //{
        //    Databases = new HashSet<Database>();
        //    DBEngines = new HashSet<DBEngine>();
        //}

        [Required]
        public string Name { get; set; }

        public int DBEngineId { get; set; }
        public string DBEngine { get; set; }
        public int ServerId { get; set; }

        public virtual ICollection<Database> Databases { get; set; }    
        public virtual Server Server { get; set; }
        //public virtual DBEngine DBEngine { get; set; }
    }
}
