using System.Collections.Generic;
using MC.Internal.DevOps.Entities;

namespace MC.Internal.DevOps.MCBusinessLogic
{
    public interface IEnvironmentManager
    {
        IEnumerable<Environment> GetEnvironmentsByTeamMemberId(string guid);
        IEnumerable<Entities.Environment> GetEnvironments();
        IEnumerable<Entities.Environment> GetEnvironments(int pageSize, int pageIndex);
    }
}