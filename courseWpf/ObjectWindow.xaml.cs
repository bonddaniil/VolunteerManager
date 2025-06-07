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
    /// Логика взаимодействия для ObjectWindow.xaml
    /// </summary>
    public partial class ObjectWindow : Window
    {
        private DbClass db = new DbClass();
        //private string[] arr = { "Handyman", "Engineer", "Builder", "Plumber", "Welder" };
        string selectAllQuery = "SELECT * FROM Objects";
        public ObjectWindow()
        {
            InitializeComponent();
            db.RecordsData(selectAllQuery, ObjectDG);
        }

        private void AddObject_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(IdAdd.Text);
            int dwelling = Int32.Parse(AddDwelling.Text);
            string town = TownAdd.Text;
            string street = StreetAdd.Text;
            int numberOfHouse = Int32.Parse(NumberOfHouseAdd.Text);

            if ((IdAdd.Text != null) && (town != null) && (street != null) && (NumberOfHouseAdd.Text != null))
            {
                string sqlQ = $"INSERT INTO Objects (object_id, type_of_house, dwellingPlace, type_of_engineering_structures, type_of_sanitary_structures, type_of_frame, type_of_roof, town, street, number_of_house) VALUES('{id}', 'Damaged', '{dwelling}', 'Damged engeneering structures ', 'Damged sanitary structures', 'Damaged frame', 'Damaged roof', '{town}', '{street}', '{numberOfHouse}')";
                db.GetAndShowData(sqlQ, ObjectDG);
            }
            else
            {
                MessageBox.Show("Not enough data");
            }
            db.RecordsData(selectAllQuery, ObjectDG);
        }

        private void DeleteObjectButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(DeleteObject.Text);
            if (DeleteObject.Text != null)
            {
                string sqlQ = $"DELETE FROM Objects WHERE object_id = '{id}'";
                db.GetAndShowData(sqlQ, ObjectDG);
            }
            else
            {
                MessageBox.Show("Недостатньо данних");
            }
            db.RecordsData(selectAllQuery, ObjectDG);
        }

        private void ToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();
        }
    }
}
