using courseWpf.Decorator;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.FabricTeam
{
    abstract class AbstractTeamDistributor
    {
        public abstract ITeam TeamDistributor(List<VolunteerDecorator> teamList);
        public House BuildHouse(string typeOfHouse, List<VolunteerDecorator> teamList)
        {
            ITeam it = TeamDistributor(teamList);
            House ret = new House();
            ret = it.BuildHouse(typeOfHouse, ret);
            return ret;
        }

        public House RepairHouse(List<VolunteerDecorator> teamList, House h)//замінити Clone
        {
            ITeam vt = TeamDistributor(teamList);
            if (h.typeOfHouse != "Damaged") { return h.Clone(); }
            House clone = h.Clone();
            clone.typeOfHouse = "Repaired";
            clone.typeOfEngineeringStructures = vt.RepairHouse("Engineering structures");
            clone.typeOfSanitaryStructures = vt.RepairHouse("Sanitary Structures");
            clone.typeOfFrame = vt.RepairHouse("Frame");
            clone.typeOfRoof = vt.RepairHouse("Roof");
            return clone;
        }
    }
}
