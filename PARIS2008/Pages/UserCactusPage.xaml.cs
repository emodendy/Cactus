using PARIS2008.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для UserCactusPage.xaml
    /// </summary>
    public partial class UserCactusPage : Page
    {
        int _id = 0;
        public UserCactusPage(int id)
        {
            InitializeComponent();
            _id = id;

            ListCactus.ItemsSource = ConnectionClass.connect.Cactus_Exhibition.Where(cactus => cactus.id_Exhibition == _id).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
