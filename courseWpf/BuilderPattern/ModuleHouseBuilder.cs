using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.BuilderPattern
{
    internal class ModuleHouseBuilder : BuilderFunc, IHouseBuilder
    {

        public void BuildFrame(ITeam vt)
        {
            dct = LookForPro(vt, "Welder");
        }

        public void BuildRoof(ITeam vt)
        {
            dct = LookForPro(vt, "Builder");
        }
        public void EngeneeringStuff(ITeam vt)
        {
            dct = LookForPro(vt, "Engineer");
        }
        public void PrepareForBuilding()
        {
            house.typeOfHouse = "Modul House";
            house.dwellingPlace = 50;
        }
        public void SanitaryStructures(ITeam vt)
        {
            dct = LookForPro(vt, "Plumber");
        }
        public House GetHouse()
        {
            house.typeOfFrame = "Modul house frame: " + SelectClassOfComponent(dct["Welder"]);
            house.typeOfRoof = "Modul house roof: " + SelectClassOfComponent(dct["Builder"]);
            house.typeOfEngineeringStructures = "Modul house engineering structures: " + SelectClassOfComponent(dct["Engineer"]);
            house.typeOfSanitaryStructures = "Modul house sanitary structures:  " + SelectClassOfComponent(dct["Plumber"]);
            return house;
        }
    }
}
