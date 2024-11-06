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
    /// Логика взаимодействия для AdminCactusPage.xaml
    /// </summary>
    public partial class AdminCactusPage : Page
    {
        int _id = 0;
        public AdminCactusPage(int id)
        {
            InitializeComponent();
            _id = id;

            ListCactus.ItemsSource = ConnectionClass.connect.Cactus_Exhibition.Where(cactus => cactus.id_Exhibition == _id).ToList();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var b = ListCactus.SelectedItem as Cactus;
                if (b != null)
                {
                    ConnectionClass.connect.Cactus.Remove(b);
                    ConnectionClass.connect.SaveChanges();
                    ListCactus.ItemsSource = ConnectionClass.connect.Exhibition.ToList();
                    MessageBox.Show($"Кактус номер {b.id_Cactus} удалена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Для начала выберите запись!!!");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
