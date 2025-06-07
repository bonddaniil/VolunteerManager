using courseWpf.Decorator;
using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseWpf.Template
{
    internal class RepairAlorithm : AbstractWorkAlgorithm
    {

        protected override House TypeOfWork(List<string> team, List<VolunteerDecorator> teamList, House h, string typeOfHouse)
        {
            switch (team[1])
            {
                case "Standart":
                    StandartTeamCreator std = new StandartTeamCreator();
                    return std.RepairHouse(teamList, h);
                case "Pro":
                    ProTeamCreator pr = new ProTeamCreator();
                    return pr.RepairHouse(teamList, h);
                default:
                    return h;
            }
        }
    }
}
