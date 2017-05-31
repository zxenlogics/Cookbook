using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public partial class ServerRole : BaseEntity
    {        
        //public ServerRole()
        //{
        //    Servers = new HashSet<Server>();
        //}

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        public virtual ICollection<Server> Servers { get; set; }
    }
}
