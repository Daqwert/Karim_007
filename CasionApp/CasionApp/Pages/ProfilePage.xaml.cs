using CasionApp.Windows;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            DataContext = App.contextUser;
            Refresh();
        }

        private void Refresh()
        {
            LVTransaction.ItemsSource = App.DB.Transaction
                .Where(x => x.UserId == App.contextUser.Id)
                .ToList()
                .OrderByDescending(x=>x.DataTime);

            LVGames.ItemsSource = App.DB.Game
                .Where(x => x.UserId == App.contextUser.Id)
                .ToList()
                .OrderByDescending(x => x.StartSession);
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new RegestrationPage(App.contextUser));
        }

        private void BTopUp_Click(object sender, RoutedEventArgs e)
        {
            new TransactionWindows().ShowDialog();
            App.mainPage.DataContext = null;
            App.mainPage.DataContext = App.contextUser;
            Refresh();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BPrintTransaction_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog().GetValueOrDefault())
            {
                printDialog.PrintVisual(LVTransaction, "");
            }
            
        }

        private void BPrintGames_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog().GetValueOrDefault())
            {
                printDialog.PrintVisual(LVGames, "");
            }
        }
    }
}
