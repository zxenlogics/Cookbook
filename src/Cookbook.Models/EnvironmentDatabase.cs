using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Internal.DevOps.Entities
{
    public class EnvironmentDatabase : BaseEntity
    {
        public int EnvironmentId { get; set; }
        public int DatabaseId { get; set; }

        // TODO: Are these needed
        public virtual Environment Environment { get; set; }
        public virtual Database Database { get; set; }  
    }
}
