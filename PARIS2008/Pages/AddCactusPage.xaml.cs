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
    /// Логика взаимодействия для AddCactusPage.xaml
    /// </summary>
    public partial class AddCactusPage : Page
    {
        public AddCactusPage()
        {
            InitializeComponent();
            cmbOrigin.ItemsSource = ConnectionClass.connect.Origin.ToList();
            cmbVid.ItemsSource = ConnectionClass.connect.Vid_Cactus.ToList();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ConnectionClass.connect.Exhibition.Add(new Exhibition
            {
                Date ,
                Rewards = txtReward.Text,
                id_Place = ((Place)cmbPlace.SelectedItem).id_Place,
            });
            ConnectionClass.connect.SaveChanges();
            NavigationService.Navigate(new AdminExhibitionPage());
        }

        private void cmbOrigin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
