using System;
using System.Collections.Generic;

using MC.Internal.DevOps.Entities;
using MC.Internal.DevOps.Data.Logging.MCLogger;

namespace MC.Internal.DevOps.MCDataAccess
{
    public class VSTSRepository : IVSTSRepository
    {
        private ILogger _logger = new Logger();

        public IEnumerable<TeamMember> GetTeamMembers(Guid teamGuid)
        {
            try
            {
                return new List<TeamMember>();
            }
            catch (Exception ex)
            {
                _logger.Log(string.Format("[VSTSRepository.GetTeamMembers] An error occured"), LogLevel.Error);
                throw;
            }
        }

        public IEnumerable<Team> GetTeams()
        {
            try
            {
                _logger.Log(string.Format("[VSTSRepository.GetTeams] 23 Teams returned"), LogLevel.Debug);
                return new List<Team>();
            }
            catch (Exception ex)
            {
                _logger.Log(string.Format("[VSTSRepository.GetTeams] An error occured"), LogLevel.Error);
                throw;
            }            
        }
    }
}
