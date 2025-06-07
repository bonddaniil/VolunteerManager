using courseWpf.FabricTeam;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.BuilderPattern
{
    internal class BuilderFunc
    {
        protected House house = new House();
        protected Dictionary<string, int> dct = new Dictionary<string, int>()
        {
                {"Handyman", 0},
                {"Engineer", 0},
                {"Builder", 0},
                {"Plumber", 0},
                {"Welder", 0},
        };
        public Dictionary<string, int> LookForPro(ITeam vt, string prof)
        {
            string key = "";
            int value = 0;
            key = prof;
            prof = $"courseWpf.Decorator.{prof}";
            foreach (var item in vt.teamList)
            {
                if (item.GetType().ToString() == prof)
                {
                    dct = item.DoVolunteerJob(dct);
                }
            }
            if (vt.GetType().ToString() == "courseWpf.FabricTeam.ProTeam" || HandymanCounter(vt) > 5)
            {
                value = dct[key] * 2;
                dct.Remove(key);
                dct.Add(key, value);
            }
            return dct;
        }
        public string SelectClassOfComponent(int counter)
        {
            if (counter < 2)
            {
                return "Class C";
            }
            else if (counter >= 2 && counter < 4)
            {
                return "Class B";
            }
            else
            {
                return "Class A";
            }
        }

        private int HandymanCounter(ITeam vt)
        {
            int counter = 0;
            foreach (var item in vt.teamList)
            {
                if (vt.GetType().ToString() == "Handyman")
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
