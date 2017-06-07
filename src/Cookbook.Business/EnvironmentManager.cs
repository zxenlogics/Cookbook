
using System.Collections.Generic;
using Environment = MC.Internal.DevOps.Entities.Environment;

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

        public IEnumerable<Entities.Environment> GetEnvironments()
        {
            return _repo.GetEnvironments();
        }

        public IEnumerable<Environment> GetEnvironments(int pageSize, int pageIndex)
        {
            return _repo.GetEnvironments(pageSize, pageIndex);
        }
    }
}
