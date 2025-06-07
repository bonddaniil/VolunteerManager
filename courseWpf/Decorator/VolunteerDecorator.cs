using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Decorator
{
    public class VolunteerDecorator : AbstacrtVolunteerMain
    {
        public string name { get; set; }
        public string surname { get; set; }

        protected AbstacrtVolunteerMain abs { get; set; }
        public VolunteerDecorator()
        {
            name = "standart name";
            surname = "standart surname";
        }
        public VolunteerDecorator(string name, string surname, AbstacrtVolunteerMain abs)
        {
            this.name = name;
            this.surname = surname;
            this.abs = abs;
        }

        public VolunteerDecorator(AbstacrtVolunteerMain abs)
        {
            this.abs = abs;
        }


        public override Dictionary<string, int> DoVolunteerJob(Dictionary<string, int> teamDict)
        {
            return this.abs.DoVolunteerJob(teamDict);
        }
    }
}
