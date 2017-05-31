using System;
using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            //CreatedDate = DateTime.Now;
            //ModifiedDate = DateTime.Now;
        }

        public int Id { get; set; }
        //[Required]
        //public DateTime CreatedDate { get; set; }
        //[Required]
        //public DateTime ModifiedDate { get; set; }
    }
}
