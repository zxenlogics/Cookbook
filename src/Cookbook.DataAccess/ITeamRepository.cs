using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MC.Internal.DevOps.Entities;

namespace MC.Internal.DevOps.MCDataAccess
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeamsByUserId();
        IEnumerable<Team> GetTeams();
        Team GetTeamById(int Id);
    }
}
