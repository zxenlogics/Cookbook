using System;
using System.Collections.Generic;
using System.Linq;

using MC.Internal.DevOps.Entities;

namespace MC.Internal.DevOps.MCDataAccess
{
    public class TeamRepository : BaseRepository, ITeamRepository
    {        
        public TeamRepository() : base()
        {
        }

        public TeamRepository(MCDbContext context)
        {
            this._context = context;
        }

        public Team GetTeamById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetTeams()
        {
            //return _dbSet.ToList();           
            return _context.Teams.ToList();
        }

        public IEnumerable<Team> GetTeamsByUserId()
        {
            return _context.Teams.ToList();
        }
    }
}
