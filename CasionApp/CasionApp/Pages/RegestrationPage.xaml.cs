using CasionApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace CasionApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegestrationPage.xaml
    /// </summary>
    public partial class RegestrationPage : Page
    {
        User contextUser;
        public RegestrationPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = ValidationLine();
            if (error.Length == 0)
            {
                if(contextUser.Id==0)
                    App.DB.User.Add(contextUser);
                App.DB.SaveChanges();
                App.contextUser = contextUser;
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show(error.ToString());
            }
        }

        private StringBuilder ValidationLine()
        {
            var error = new StringBuilder();
            var valContext = new ValidationContext(contextUser);
            var valResult = new List<ValidationResult>();
            if(!Validator.TryValidateObject(contextUser, valContext, valResult))
            {
                foreach(var item in valResult)
                {
                    error.AppendLine(item.ErrorMessage);
                }
            }
            return error;
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
