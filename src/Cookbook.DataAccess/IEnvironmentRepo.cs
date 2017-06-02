using System.Collections.Generic;

namespace MC.Internal.DevOps.MCDataAccess
{
    public interface IEnvironmentRepo
    {
        IEnumerable<Entities.Environment> GetEnvironmentsByTeamMemberId(string guid);
    }
}
