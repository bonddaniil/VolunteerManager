using System;
using System.Collections;
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

namespace courseWpf
{
    /// <summary>
    /// Логика взаимодействия для VolunteerWindow.xaml
    /// </summary>
    public partial class VolunteerWindow : Window
    {
        private DbClass db = new DbClass();
        private string[] arr = { "Handyman", "Engineer", "Builder", "Plumber", "Welder" };
        string selectAllQuery = "SELECT * FROM Volunteers";
        public VolunteerWindow()
        {
            
            InitializeComponent();
            ProfessionComboBox.ItemsSource = arr;
            db.RecordsData(selectAllQuery, VolunteerDG);
        }

        private void AddVolunteerButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(IDAdd.Text);
            string name = NameAdd.Text;
            string surname = SurnameAdd.Text;
            int teamId = Int32.Parse(IDAdd.Text);
            string profession = arr[ProfessionComboBox.SelectedIndex];

            if ((IDAdd.Text!=null)&&(name!= null) && (surname != null) && (IDAdd.Text != null)&& (profession!=null))
            {
                string sqlQ = $"INSERT INTO Volunteers (volunteer_id, name, surname, team_id, profession_name) VALUES('{id}', '{name}', '{surname}', '{teamId}', '{profession}')";
                db.GetAndShowData(sqlQ, VolunteerDG);
            }
            else
            {
                MessageBox.Show("Not enough data");
            }
            db.RecordsData(selectAllQuery, VolunteerDG);
        }

        private void DeleteVolunteerButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(IdDelete.Text);
            if (IdDelete.Text != null)
            {
                string sqlQ = $"DELETE FROM Volunteers WHERE volunteer_id = '{id}'";
                db.GetAndShowData(sqlQ, VolunteerDG);
            }
            else
            {
                MessageBox.Show("Недостатньо данних");
            }
            db.RecordsData(selectAllQuery, VolunteerDG);
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
