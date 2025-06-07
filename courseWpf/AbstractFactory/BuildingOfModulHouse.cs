using courseWpf.BuilderPattern;
using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.AbstractFactory
{
    internal class BuildingOfModulHouse : AbstractReconstruction
    {

        public House Reconstruction(ITeam vt)
        {
            ModuleHouseBuilder moduleBuilder = new ModuleHouseBuilder();
            moduleBuilder.PrepareForBuilding();
            moduleBuilder.EngeneeringStuff(vt);
            moduleBuilder.SanitaryStructures(vt);
            moduleBuilder.BuildFrame(vt);
            moduleBuilder.BuildRoof(vt);
            return moduleBuilder.GetHouse();
        }
    }
}
