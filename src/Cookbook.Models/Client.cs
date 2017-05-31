using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MC.Internal.DevOps.Entities
{
    public partial class Client : BaseEntity
    {

        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(5)]
        public string Abbreviation { get; set; }
        
        //public virtual ICollection<Environment> Environments { get; set; }
    }
}
