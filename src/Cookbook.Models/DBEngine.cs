using System.ComponentModel.DataAnnotations;

namespace MC.Internal.DevOps.Entities
{
    public class DBEngine : BaseEntity
    {
        //public DBEngine()
        //{
        //    DBInstances = new HashSet<DBInstance>();
        //}

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        //public int ServerId { get; set; }

        //public int DefaultInstance_Id { get; set; }

        //public virtual DBInstance DBInstance { get; set; }        
        //public virtual ICollection<DBInstance> DBInstances { get; set; }
        //public virtual Server Server { get; set; }
    }
}
