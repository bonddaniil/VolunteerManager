using courseWpf.Decorator;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWpf.AbstractFactory;

namespace courseWpf.FabricTeam
{
    internal class StandartTeam : ITeam
    {
        public List<VolunteerDecorator> teamList { get; set; }
        public StandartTeam(List<VolunteerDecorator> teamList)
        {
            this.teamList = teamList;
        }

        public House BuildHouse(string typeOfHouse, House ret)
        {

            switch (typeOfHouse)
            {
                case "Module House":
                    BuildingOfModulHouse bmd = new BuildingOfModulHouse();
                    return bmd.Reconstruction(this);
                case "New House":
                    BuildingOfNewHouse bnh = new BuildingOfNewHouse();
                    return bnh.Reconstruction(this);
                default:
                    return ret;
            }
        }

        public string RepairHouse(string partOfHouse)
        {
            if (teamList.Count > 5)
            {
                return (partOfHouse + ": " + "is reapaired");
            }
            else
            {
                return (partOfHouse + ": " + "is temporarily reapaired");
            }
        }
    }
}
