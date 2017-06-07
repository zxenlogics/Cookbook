using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MC.Internal.DevOps.Entities;

namespace MC.Internal.DevOps.MCBusinessLogic
{
    public interface IDemoBusinessLogic
    {
        IEnumerable<Team> GetDemoTeams();
    }
}
