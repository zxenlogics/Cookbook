using System;
using System.Collections.Generic;

using MC.Internal.DevOps.Entities;
using MC.Internal.DevOps.MCDataAccess;

namespace MC.Internal.DevOps.BusinessLogic
{
    public class DemoBusinessLogic : IDemoBusinessLogic
    {
        private ITeamRepository _repo;

        public DemoBusinessLogic()
        {
            //_repo = new TeamRepository();
        }

        public DemoBusinessLogic(ITeamRepository repo)
        {            
            try
            {
                _repo = repo;
            }
            catch (Exception ex)
            {
                //Log Exception here
                throw;
            }
        }

        public IEnumerable<Team> GetDemoTeams()
        {
            
            try
            {
                return _repo.GetTeams();
            }
            catch (Exception ex)
            {
                //Log Exception here
                throw;
            }
        }
    }
}
