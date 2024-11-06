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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PARIS2008.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserExhibitionPage.xaml
    /// </summary>
    public partial class UserExhibitionPage : Page
    {
        public UserExhibitionPage()
        {
            InitializeComponent();
            ListExhibitions.ItemsSource = ConnectionClass.connect.Exhibition.ToList(); 
        }

        private void GridViewColumn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListExhibitions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var a = ListExhibitions.SelectedItem as Exhibition;
            if (a != null)
            {
                NavigationService.Navigate(new UserCactusPage(a.id_Exhibition));
            }
        }
    }
}
