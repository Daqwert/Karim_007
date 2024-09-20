using CasionApp.Models;
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

namespace CasionApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Login)&& !string.IsNullOrEmpty(Password))
            {
                var user = App.DB.User.FirstOrDefault(x => x.Login == Login && x.Password == Password);
                if (user != null)
                {
                    App.contextUser = user;
                    NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            else
            {
                MessageBox.Show("Поля пыстые");
            }
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegestrationPage(new User()));
        }
    }
}
