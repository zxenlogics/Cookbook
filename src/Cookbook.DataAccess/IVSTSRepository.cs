using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
using System.Collections.Generic;

namespace MC.Internal.DevOps.MCDataAccess
{
    public interface IVstsRepository
    {
        List<WebApiTeam> GetTeamsAsync(string projectId);
        List<IdentityRef> GetTeamMembersAsync(string projectId, string teamId);

    }
}
