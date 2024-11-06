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
    /// Логика взаимодействия для AdminExhibitionPage.xaml
    /// </summary>
    public partial class AdminExhibitionPage : Page
    {
        public AdminExhibitionPage()
        {
            InitializeComponent();
            ListExhibitions.ItemsSource = ConnectionClass.connect.Exhibition.ToList();
        }

        private void ListExhibitions_MouseDoubleClick(object sender, MouseButtonEventArgs e )
        {
            var a = ListExhibitions.SelectedItem as Exhibition;
            if (a != null)
            {
                NavigationService.Navigate(new AdminCactusPage(a.id_Exhibition));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var b = ListExhibitions.SelectedItem as Exhibition;
                if (b != null)
                {
                    ConnectionClass.connect.Exhibition.Remove(b);
                    ConnectionClass.connect.SaveChanges();
                    ListExhibitions.ItemsSource = ConnectionClass.connect.Exhibition.ToList();
                    MessageBox.Show($"Выставка номер {b.id_Exhibition} удалена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Для начала выберите запись!!!");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddExhibitionPage());
        }
    }
}
