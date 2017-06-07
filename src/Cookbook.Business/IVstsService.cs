using System.Collections.Generic;

namespace MC.Internal.DevOps.MCBusinessLogic
{
    public interface IVstsService
    {
        List<string> GetTeamMemembers(string projectId, string teamId);
        List<string> GetTeams(string teamId);
    }
}