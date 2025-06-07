using courseWpf.DBClasses;
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

namespace courseWpf
{
    /// <summary>
    /// Логика взаимодействия для TeamWindow.xaml
    /// </summary>
    public partial class TeamWindow : Window
    {
        private DbClass db = new DbClass();
        private string[] arr = { "Pro", "Standart"};
        string selectAllQuery = "SELECT * FROM Teams";
        public TeamWindow()
        {
            InitializeComponent();
            TypeOfTeamSelector.ItemsSource = arr;
            db.RecordsData(selectAllQuery, TeamDG);
            
        }

        private void AddTeamButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(IdAdd.Text);
            int objectId = Int32.Parse(IdOdjectAdd.Text);
            string typeOfTeam = arr[TypeOfTeamSelector.SelectedIndex];

            if ((IdAdd.Text != null) && (IdOdjectAdd.Text != null) && (typeOfTeam != null))
            {
                string sqlQ = $"INSERT INTO Teams (team_id, object_id, team_type_of_team) VALUES('{id}', '{objectId}', '{typeOfTeam}')";
                db.GetAndShowData(sqlQ, TeamDG);
            }
            else
            {
                MessageBox.Show("Not enough data");
            }
            db.RecordsData(selectAllQuery, TeamDG);
        }

        private void DeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(IdDelete.Text);
            if (IdDelete.Text != null)
            {
                string sqlQ = $"DELETE FROM Teams WHERE team_id = '{id}'";
                db.GetAndShowData(sqlQ, TeamDG);
            }
            else
            {
                MessageBox.Show("Недостатньо данних");
            }
            db.RecordsData(selectAllQuery, TeamDG);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();
        }
    }
}
