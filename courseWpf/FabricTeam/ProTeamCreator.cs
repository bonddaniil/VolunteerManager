using courseWpf.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.FabricTeam
{
    internal class ProTeamCreator : AbstractTeamDistributor
    {
        public override ITeam TeamDistributor(List<VolunteerDecorator> teamList)
        {
            return new ProTeam(teamList);
        }
    }
}
