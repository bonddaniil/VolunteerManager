using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Decorator
{
    internal class Handyman : VolunteerDecorator
    {
        public Handyman(string name, string surname, AbstacrtVolunteerMain abs) : base(name, surname, abs)
        {
        }
    }
}
