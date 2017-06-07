using System;
using System.Collections.Generic;
using System.Configuration;

using MC.Internal.DevOps.Data.Logging.MCLogger;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.TeamFoundation.Core.WebApi;

namespace MC.Internal.DevOps.MCDataAccess
{
    public class VstsRepository : IVstsRepository
    {
        private string _accessToken;
        private string _vsoUri;
        private TeamHttpClient _teamClient;

        private ILogger _logger = new Logger();

        public VstsRepository()
        {
            try
            {
                _accessToken = ConfigurationManager.AppSettings["AccessToken"];
                _vsoUri = ConfigurationManager.AppSettings["VsoUri"];

                if (string.IsNullOrWhiteSpace(_accessToken) || string.IsNullOrWhiteSpace(_vsoUri))
                    throw new ConfigurationErrorsException();
            }
            catch (ConfigurationErrorsException ex)
            {
                _logger.Log(string.Format("[VSTSRepository] Couldn't read config file or 'AccessToken' and/or 'VsoUri' keys are missing. {0}",
                    ex.Message), LogLevel.Error);
            }
            catch (Exception ex)
            {
                _logger.Log(string.Format("[VSTSRepository] Internal error occurred. {0}", ex.Message), LogLevel.Error);
            }

            var creds = new VssBasicCredential(string.Empty, _accessToken);
            var vssConnection = new VssConnection(new Uri(_vsoUri), creds);

            _teamClient = vssConnection.GetClient<TeamHttpClient>();
        }
        public List<WebApiTeam> GetTeamsAsync(string projectId)
        {
            try
            {
                var teams = _teamClient.GetTeamsAsync(projectId).Result;
                // _logger.Log(string.Format("[VSTSRepository.GetTeams] {0} Teams returned", teams.Count), LogLevel.Debug);

                return teams;
            }
            catch (Exception ex)
            {
                //_logger.Log(string.Format("[VSTSRepository.GetTeams] Couldn't retrieve Teams. " +
                //    "AccessToken = {0}, VsoUri = {1}. Exception: {2}", _accessToken, _vsoUri, ex.Message), LogLevel.Error);
                throw;
            }
        }

        public List<IdentityRef> GetTeamMembersAsync(string projectId, string teamId)
        {
            try
            {
                var memebers = _teamClient.GetTeamMembersAsync(projectId, teamId).Result;
                //_logger.Log(string.Format("[VSTSRepository.GetTeamMembers] {0} TeamMembers returned", memebers.Count), LogLevel.Debug);

                return memebers;
            }
            catch (Exception ex)
            {
                //_logger.Log(string.Format("[VSTSRepository.GetTeamMembers] Couldn't retrieve TeamMemebers. " +
                //    "AccessToken = {0}, VsoUri = {1}. Exception: {2}", _accessToken, _vsoUri, ex.Message), LogLevel.Error);
                throw;
            }
        }
    }
}
