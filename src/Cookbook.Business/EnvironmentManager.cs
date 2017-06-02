using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MC.Internal.DevOps.Entities;
using MC.Internal.DevOps.MCDataAccess;

namespace MC.Internal.DevOps.MCBusinessLogic
{
    public class EnvironmentManager : IEnvironmentManager
    {
        private readonly IEnvironmentRepo _repo;

        public EnvironmentManager(IEnvironmentRepo repo)
        {
            _repo = repo;
        }
        public IEnumerable<Entities.Environment> GetEnvironmentsByTeamMemberId(string guid)
        {
            return _repo.GetEnvironmentsByTeamMemberId("2569-65874-856914-25698741");
        }
    }
}
