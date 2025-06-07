using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWpf.FabricTeam;
using courseWpf.Decorator;
using courseWpf.Houses;
using System.Windows.Input;

namespace courseWpf.Template
{
    abstract class AbstractWorkAlgorithm
    {
        public House TemplateWorkAlgoritm(List<string> vol, List<string> team, House h, string typeOfHouse, List<string> house)
        {
            List<VolunteerDecorator> teamList = CreateVolunteers(vol);
            h = TypeOfWork(team, teamList, h, typeOfHouse);
            h = AddAdress(h, house);
            return h;
        }
        public House AddAdress(House h, List<string> house)
        {
            h.idHouse = Int32.Parse(house[0]);
            h.town = house[3];
            h.street = house[4];
            h.numberOfHouse = Int32.Parse(house[5]);
            return h;
        }


        protected List<VolunteerDecorator> CreateVolunteers(List<string> vol)
        {
            VolunteerMain vm = new VolunteerMain();

            string name = "";
            string surname = "";
            string prof = "";
            VolunteerDecorator vd = new VolunteerDecorator();
            List<VolunteerDecorator> teamList = new List<VolunteerDecorator>();
            for (int i = 0; i < vol.Count; i++)
            {
                switch (i % 3)
                {
                    case 0: name = vol[i]; break;
                    case 1: surname = vol[i]; break;
                    case 2:
                        prof = vol[i];
                        switch (prof)
                        {
                            case "Builder":
                                teamList.Add(new Builder(name, surname, vm));
                                break;
                            case "Engineer":
                                teamList.Add(new Engineer(name, surname, vm));
                                break;
                            case "Handyman":
                                teamList.Add(new Handyman(name, surname, vm));
                                break;
                            case "Plumber":
                                teamList.Add(new Plumber(name, surname, vm));
                                break;
                            case "Welder":
                                teamList.Add(new Welder(name, surname, vm));
                                break;
                        }
                        break;
                }

            }
            return teamList;


        }
        protected abstract House TypeOfWork(List<string> team, List<VolunteerDecorator> teamList, House h, string typeOfHouse);
        
    }
}
