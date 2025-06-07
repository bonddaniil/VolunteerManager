using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.BuilderPattern
{
    internal class NewHouseBuilder : BuilderFunc, IHouseBuilder
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
            house.typeOfHouse = "New House";
            house.dwellingPlace = 250;
        }

        public void SanitaryStructures(ITeam vt)
        {
            dct = LookForPro(vt, "Plumber");
        }
        public House GetHouse()
        {
            house.typeOfFrame = "New house frame: " + SelectClassOfComponent(dct["Welder"]);
            house.typeOfRoof = "New house roof: " + SelectClassOfComponent(dct["Builder"]);
            house.typeOfEngineeringStructures = "New house engineering structures: " + SelectClassOfComponent(dct["Engineer"]);
            house.typeOfSanitaryStructures = "New house sanitary structures:  " + SelectClassOfComponent(dct["Plumber"]);
            return house;
        }
    }
}
