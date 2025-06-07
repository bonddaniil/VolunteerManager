using courseWpf.Decorator;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.FabricTeam
{
    public interface ITeam
    {
        List<VolunteerDecorator> teamList { get; set; }
        House BuildHouse(string typeOfHouse, House ret);
        string RepairHouse(string partOfHouse);
    }
}
