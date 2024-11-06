using PARIS2008.DB;
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

namespace PARIS2008.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddExhibitionPage.xaml
    /// </summary>
    public partial class AddExhibitionPage : Page
    {
        public AddExhibitionPage( )
        {
            InitializeComponent();
            cmbPlace.ItemsSource = ConnectionClass.connect.Place.ToList();
            
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ConnectionClass.connect.Exhibition.Add(new Exhibition
            {
                Date = DateTime.Parse(dateTime.Text),
                Rewards = txtReward.Text,
                id_Place = ((Place)cmbPlace.SelectedItem).id_Place,
            });
            ConnectionClass.connect.SaveChanges();
            NavigationService.Navigate(new AdminExhibitionPage());
        }

        private void cmbPlace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = cmbPlace.SelectedItem as Place;
            var placee = (from place in ConnectionClass.connect.Place
                          where place.id_Place == p.id_Place
                          select place).FirstOrDefault();
            cmbPlace.SelectedItem = placee;
        }
    }
}
