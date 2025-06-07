using courseWpf.DBClasses;
using courseWpf.Decorator;
using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWpf.Template;

using courseWpf.FabricTeam;


namespace courseWpf.Mediator
{
    internal class WorkMediator : IMediator
    {
        private BuildingOfNewHouseMedia bonh;
        private RepairingOfHouseMedia roh;
        private BuildingOfModuleHouseMedia bomhm;
        private List<string> vol { get; set; }
        private List<string> team { get; set; }
        private List<string> house { get; set; }
        public WorkMediator(BuildingOfNewHouseMedia bonh, RepairingOfHouseMedia roh, BuildingOfModuleHouseMedia bomhm,  List<string> vol,
            List<string> team, List<string> house)
        {
            this.bonh = bonh;
            this.bonh.SetMediator(this);
            this.roh = roh;
            this.roh.SetMediator(this);
            this.bomhm = bomhm;
            this.bomhm.SetMediator(this);
            this.vol = vol;
            this.team = team;
            this.house = house;
        }
        public House Notify(object sender, int typeOfWork)
        {
            if (typeOfWork == 0)
            {
                House h = new House(house);
                RepairAlorithm buildAlgoritm = new RepairAlorithm();
                return buildAlgoritm.TemplateWorkAlgoritm(vol, team, h, "Damaged", house);
            }
            else if (typeOfWork == 1)
            {
                House h = new House();
                BuildAlgoritm buildAlgoritm = new BuildAlgoritm();
                h = buildAlgoritm.TemplateWorkAlgoritm(vol, team, h, "Module House", house);
                return h;
            }
            else
            {
                House h = new House();
                BuildAlgoritm buildAlgoritm = new BuildAlgoritm();
                h = buildAlgoritm.TemplateWorkAlgoritm(vol, team, h, "New House", house);
                return h;
            }
        }

        /*private House SelectTeamAndBuild(List<string> team, List<VolunteerDecorator> teamList, House h, string typeOfHouse)
        {

            switch (team[1])
            {
                case "Standart":
                    StandartTeamCreator std = new StandartTeamCreator();
                    return std.BuildHouse(typeOfHouse, teamList);
                case "Pro":
                    ProTeamCreator pr = new ProTeamCreator();
                    return pr.BuildHouse(typeOfHouse, teamList);
                default:
                    return h;
            }
        }*/
        /*private List<VolunteerDecorator> CreateVolunteers(List<string> vol)
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

       /* private House SelectTeamAndRepair(List<string> team, List<VolunteerDecorator> teamList, House h)
        {
            //ITeam ret = new ITeam();
            switch (team[1])
            {
                case "Standart":
                    StandartTeamCreator std = new StandartTeamCreator();
                    return std.RepairHouse(teamList, h);
                case "Pro":
                    ProTeamCreator pr = new ProTeamCreator();
                    return pr.RepairHouse(teamList, h);
                default:
                    return h;
            }
        }*/


    }
}
