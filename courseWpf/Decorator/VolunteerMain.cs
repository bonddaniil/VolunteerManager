using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Decorator
{
    public class VolunteerMain : AbstacrtVolunteerMain
    {
        public override Dictionary<string, int> DoVolunteerJob(Dictionary<string, int> teamDict)
        {
            teamDict["Handyman"]++;
            return teamDict;
        }
    }
}
