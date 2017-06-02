using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MC.Internal.DevOps.MCDataAccess
{
    public abstract class BaseRepository
    {
        protected MCDbContext _context;

        public BaseRepository()
        {
            //_context = new MCDbContext();
        }
    }
}
