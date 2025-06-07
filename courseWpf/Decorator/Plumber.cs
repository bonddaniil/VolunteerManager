using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Decorator
{
    public class Plumber : VolunteerDecorator
    {
        public Plumber(string name, string surname, AbstacrtVolunteerMain abs) : base(name, surname, abs)
        {
        }
        public override Dictionary<string, int> DoVolunteerJob(Dictionary<string, int> teamDict)
        {
            teamDict = base.DoVolunteerJob(teamDict);
            teamDict["Plumber"]++;
            return teamDict;
        }
    }
}
