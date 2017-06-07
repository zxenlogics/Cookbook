using MC.Internal.DevOps.MCDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MC.Internal.DevOps.MCBusinessLogic
{
    public class VstsService : IVstsService
    {
        private readonly IVstsRepository _vstsRepo;

        public VstsService(IVstsRepository vstsRepo)
        {
            _vstsRepo = vstsRepo;
        }

        public List<string> GetTeams(string projectId)
        {
            var teams = new List<string>();
            var teamsList = _vstsRepo.GetTeamsAsync(projectId);

            if (teamsList.Any())
            {
                foreach (var team in teamsList)
                {
                    teams.Add(team.Name);
                }
            }

            return teams;
        }

        public List<string> GetTeamMemembers(string projectId, string teamId)
        {
            var members = new List<string>();
            var membersList = _vstsRepo.GetTeamMembersAsync(projectId, teamId);

            if (membersList.Any())
            {
                foreach (var member in membersList)
                {
                    members.Add(member.DisplayName);
                }
            }

            return members;
        }
    }
}
