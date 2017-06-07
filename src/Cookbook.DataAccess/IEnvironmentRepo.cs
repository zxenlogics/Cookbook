using System.Collections.Generic;

namespace MC.Internal.DevOps.MCDataAccess
{
    public interface IEnvironmentRepo
    {
        IEnumerable<Entities.Environment> GetEnvironmentsByTeamMemberId(string guid);
        IEnumerable<Entities.Environment> GetEnvironments();
        IEnumerable<Entities.Environment> GetEnvironments(int pageSize, int pageIndex);
    }
}
