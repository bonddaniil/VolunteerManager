using courseWpf.FabricTeam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.BuilderPattern
{
    internal interface IHouseBuilder
    {
        void PrepareForBuilding();
        void EngeneeringStuff(ITeam vt);
        void SanitaryStructures(ITeam vt);
        void BuildFrame(ITeam vt);
        void BuildRoof(ITeam vt);
    }
}
