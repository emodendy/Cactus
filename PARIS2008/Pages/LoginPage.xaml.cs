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
using PARIS2008.DB;

namespace PARIS2008.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            var LogRole = ConnectionClass.connect.User.FirstOrDefault(log => log.Login == login && log.Password == password);

            ConnectionClass.role = LogRole.Role;
            if (ConnectionClass.role.Role1 == "Админ")
            {
                MessageBox.Show("Вы зашли как админ");
                NavigationService.Navigate(new AdminExhibitionPage());
            }
            if (ConnectionClass.role.Role1 == "Пользователь")
            {
                MessageBox.Show("Вы зашли как обычный юзер");
                NavigationService.Navigate(new UserExhibitionPage());
            }
        }
    }
}
