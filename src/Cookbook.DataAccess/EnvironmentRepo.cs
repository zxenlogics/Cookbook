using System;
using System.Collections.Generic;
using System.Linq;

using MC.Internal.DevOps.Entities;
using Environment = MC.Internal.DevOps.Entities.Environment;

namespace MC.Internal.DevOps.MCDataAccess
{
    public class EnvironmentRepo : BaseRepository, IEnvironmentRepo
    {
        public EnvironmentRepo() : base()
        {            
            _context = new MCDbContext();
        }

        public EnvironmentRepo(MCDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Environment> GetEnvironments()
        {
            return _context.Environments;
        }

        public IEnumerable<Environment> GetEnvironments(int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        #region << Mock Data >>
        public IEnumerable<Environment> GetEnvironmentsByTeamMemberId(string guid)
        {
            List<Environment> envList = new List<Environment>()
            {
                new Environment()
                {
                    Id = 1, Name = "QA Test 1", State = "Ready", EnvironmentType = new EnvironmentType() { Id = 1, Name = "QA"},
                    IsCluster = true, LastUpdated = DateTime.Now.AddDays(-4), ClientId = 1, EnvironmentTypeId = 1,
                    Notes = "First up", Client = new Client() { Id = 1, Abbreviation = "MSSB", Name = "Morgan Stanley Smith Barney"},
                    Servers = GetServers().ToList(), CurrentVersion = "8.1.50.00000",
                    TargetVersion = "8.2.60.57420"
                },
                new Environment()
                {
                    Id = 2, Name = "QA Test 2", State = "Failed", EnvironmentType = new EnvironmentType() { Id = 2, Name = "Test"},
                    IsCluster = true, LastUpdated = DateTime.Now.AddDays(-10), ClientId = 2, EnvironmentTypeId = 2,
                    Notes = "Second up", Client = new Client() { Id = 2, Abbreviation = "LT", Name = "Lending Tree"},
                    Servers = GetServers().ToList(), CurrentVersion = "8.4.70.00022",
                    TargetVersion = "9.0.0.55656"
                }
            };

            return envList;
        }

        private IEnumerable<Server> GetServers()
        {
            List<Server> servers = new List<Server>()
            {
                new Server()
                {
                    Id = 1, Hostname = "QAPPELC11", IP = "10.0.5.82", EnvironmentId = 1, DomainId = 1, 
                    Domain = new Domain() { Id = 1, Name = "Accenture", DomainAbbreviation = "Acc" }                   
                },
                new Server()
                {
                    Id = 2, Hostname = "DWEBLCAPI1", IP = "10.7.6.16", EnvironmentId = 1, DomainId = 1,
                    Domain = new Domain() { Id = 2, Name = "Mortgagecadence", DomainAbbreviation = "MC" }
                }
            };

            return servers;
        }

        private IEnumerable<Project> GetProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project() { Id = 1, Name = "Project Ichi", IsActive = true },
                new Project() { Id = 2, Name = "Project Ni", IsActive = true },
                new Project() { Id = 3, Name = "Project San", IsActive = true }
            };

            return projects;
        }
        #endregion

    }
}
