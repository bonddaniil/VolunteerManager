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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace courseWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VolunteerButton_Click(object sender, RoutedEventArgs e)
        {
            VolunteerWindow vw = new VolunteerWindow();
            Hide();
            vw.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void TeamButton_Click(object sender, RoutedEventArgs e)
        {
            TeamWindow tw = new TeamWindow();
            Hide();
            tw.Show();
        }

        private void ObjectButton_Click(object sender, RoutedEventArgs e)
        {
            ObjectWindow ow = new ObjectWindow();
            Hide();
            ow.Show();
        }


        private void VolunteerJobButton_Click(object sender, RoutedEventArgs e)
        {
            DoVolunteerJobWindow dvw = new DoVolunteerJobWindow();
            Hide();
            dvw.Show();
        }
    }
}
