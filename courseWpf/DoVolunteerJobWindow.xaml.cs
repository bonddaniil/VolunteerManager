using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using courseWpf.DBClasses;
using courseWpf.Decorator;
using courseWpf.Houses;
using courseWpf.FabricTeam;
using courseWpf.AbstractFactory;
using courseWpf.Mediator;

namespace courseWpf
{
    /// <summary>
    /// Логика взаимодействия для DoVolunteerJobWindow.xaml
    /// </summary>
    public partial class DoVolunteerJobWindow : Window
    {
        private DbClass db = new DbClass();
        private string[] arr = { "Repair this house", "Build a new Module house", "Build a new House" };
        private string selectAllQuery = "SELECT * FROM Objects";
        string selectAllTeams = "SELECT * FROM Teams";
        private string[] ids;

        List<VolunteerDecorator> teamList= new List<VolunteerDecorator>();
        public DoVolunteerJobWindow()
        {
            InitializeComponent();
            ids = db.GetComboData("team_id", "Teams");
            db.RecordsData(selectAllQuery, ObjectDG);
            db.RecordsData(selectAllTeams, TeamDG);
            TeamIds.ItemsSource = ids;
            TypeOfWork.ItemsSource = arr;
        }

        private void BigRedButton_Click(object sender, RoutedEventArgs e)
        {
            string id = ids[TeamIds.SelectedIndex];
            string objId = "";

            string qVolunteers = $"SELECT Volunteers.name, Volunteers.surname, Volunteers.profession_name FROM Volunteers WHERE team_id = {id}";
            string qTeam = $"SELECT Teams.object_id, Teams.team_type_of_team FROM Teams WHERE team_id = {id}";
            List<string> vol = db.ReadData(qVolunteers, 3);
            List<string> team = db.ReadData(qTeam, 2);
            
            objId = team[0];
            string qHouse = $"SELECT Objects.object_id, Objects.type_of_house, Objects.dwellingPlace, Objects.town, Objects.street, Objects.number_of_house FROM Objects WHERE object_id = {objId}";
            List<string> house = db.ReadData(qHouse, 6);

            BuildingOfNewHouseMedia bonhm = new BuildingOfNewHouseMedia();
            RepairingOfHouseMedia rohm = new RepairingOfHouseMedia();
            BuildingOfModuleHouseMedia bomhm = new BuildingOfModuleHouseMedia();
            House h = new House();
            new WorkMediator(bonhm, rohm, bomhm, vol, team, house);

            if(TypeOfWork.SelectedIndex == 0)
            {
                h = rohm.SendMessage();
                
            }
            if(TypeOfWork.SelectedIndex == 1)
            {
                h = bomhm.SendMessage();
            }
            if (TypeOfWork.SelectedIndex == 2)
            {
                h = bonhm.SendMessage();
            }
            string qHouseAdd = $"UPDATE Objects SET Objects.type_of_house = '{h.typeOfHouse}', Objects.dwellingPlace = '{h.dwellingPlace}', " +
                 $"Objects.type_of_engineering_structures = '{h.typeOfEngineeringStructures}', Objects.type_of_sanitary_structures = '{h.typeOfSanitaryStructures}', " +
                 $"Objects.type_of_frame = '{h.typeOfFrame}', Objects.type_of_roof = '{h.typeOfRoof}', Objects.town = '{h.town}', " +
                 $"Objects.street = '{h.street}', Objects.number_of_house = '{h.numberOfHouse}' WHERE Objects.object_id = {h.idHouse}";

            db.GetAndShowData(qHouseAdd, ObjectDG);
            db.RecordsData(selectAllQuery, ObjectDG);
        }
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
                    case 2: prof = vol[i];
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

        }*/


        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();
        }
    }
}
