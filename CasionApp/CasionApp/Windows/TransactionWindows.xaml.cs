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
using System.Windows.Shapes;

namespace CasionApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для TransactionWindows.xaml
    /// </summary>
    public partial class TransactionWindows : Window
    {
        int transferAmount;
        public TransactionWindows()
        {
            InitializeComponent();

            DataContext = App.contextUser;
        }

        private void BSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int transferAmount = Convert.ToInt32(TBMoney.Text);
                string numberBank = TBMoney.Text;
                if (!string.IsNullOrEmpty(numberBank) && transferAmount > 0)
                {
                    if (transferAmount < App.contextUser.Balance)
                    {
                        var transaction = new Transaction()
                        {
                            UserId = App.contextUser.Id,
                            AmountMoney = transferAmount,
                            DataTime = DateTime.Now,
                            IsTopUp = false
                        };
                        App.DB.Transaction.Add(transaction);
                        App.DB.SaveChanges();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств");
                    }
                }
                else
                {
                    MessageBox.Show("Пустые поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BReplenish_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int transferAmount = Convert.ToInt32(TBMoney.Text);
                string numberBank = TBMoney.Text;
                if (!string.IsNullOrEmpty(numberBank) && transferAmount > 0)
                {

                    var transaction = new Transaction()
                    {
                        UserId = App.contextUser.Id,
                        AmountMoney = transferAmount,
                        DataTime = DateTime.Now,
                        IsTopUp = true
                    };
                    App.DB.Transaction.Add(transaction);
                    App.DB.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пустые поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
