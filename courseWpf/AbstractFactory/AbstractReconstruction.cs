using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.AbstractFactory
{
    public interface AbstractReconstruction
    {
        House Reconstruction(ITeam vt);
    }
}
