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
    public class ProTeam : ITeam
    {
        public List<VolunteerDecorator> teamList { get; set; }
        public ProTeam(List<VolunteerDecorator> teamList)
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
            return (partOfHouse + ": " + "is reapaired");
        }
    }
}
