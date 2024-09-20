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
    /// Логика взаимодействия для RoulettePage.xaml
    /// </summary>
    public partial class RoulettePage : Page
    {
        List<Bet> listBets = new List<Bet>();
        public Bet SelectBet { get; set; }
        public string Result { get; set; }
        
        public int BetMoney { get; set; }

        public Game contextGame = new Game() { Name="Roulet", UserId=App.contextUser.Id};
        public RoulettePage()
        {
            InitializeComponent();
            CreateBets();
            SPDataGame.DataContext = contextGame;
            Bets.ItemsSource = listBets;
            DataContext = this;
        }

        private void CreateBets()
        {
            listBets.Add(new Bet() { Name = "Красное" });
            listBets.Add(new Bet() { Name = "Черное" });
            for (int i = 0; i < 37; i++)
            {
                listBets.Add(new Bet() { Name = i.ToString() });
            }
           
        }

        

        private void BSpin_Click(object sender, RoutedEventArgs e)
        {


            if(BetMoney>0 && SelectBet != null && BetMoney<App.contextUser.Balance)
            {
                if (contextGame.StartSession == DateTime.MinValue)
                {
                    contextGame.StartSession = DateTime.Now;
                    contextGame.ResultGame = 0;
                    App.DB.Game.Add(contextGame);
                    App.DB.SaveChanges();
                }
                   

                ImageScaleTransform.ScaleY *= -1;
                var random = new Random();
                int result = random.Next(0, 37);


                var gameRound = new RoundGame()
                {
                    GameId = contextGame.Id,
                    DateTime = DateTime.Now,
                    ResultNumber = result
                };

                int winnigMoney = 0;
                try
                {
                    if (result == Convert.ToInt32(SelectBet.Name))
                    {
                        winnigMoney = BetMoney * 10;
                    }
                    else
                    {
                        winnigMoney -= BetMoney;
                    }
                }
                catch
                {
                    if ((result % 2 == 0 && SelectBet.Name == "Черное") || (result % 2 != 0 && SelectBet.Name == "Красное"))
                        winnigMoney = BetMoney * 2;
                    else
                        winnigMoney -= BetMoney;
                        
                }
                gameRound.ResultMoney = winnigMoney;
                App.DB.RoundGame.Add(gameRound);
                App.DB.SaveChanges();
                contextGame.ResultGame += winnigMoney;
                if (result == 0)
                    Result = "Zero ";
                else if (result % 2 == 0)
                    Result = "Черное ";
                else if (result % 2 != 0)
                    Result = "Красное ";

                Result += result.ToString();

                DataContext = null;
                SPDataGame.DataContext = null;
                DataContext = this;
                SPDataGame.DataContext = contextGame;
            }
            else
            {
                MessageBox.Show("Пыстые поля или недостаточно средств");
            }
            
        }

        private void BEndGame_Click(object sender, RoutedEventArgs e)
        {
            if (contextGame.StartSession != DateTime.MinValue)
            {
                contextGame.EndSession = DateTime.Now;
                App.DB.SaveChanges();
                contextGame = new Game() { Name = "Roulet", UserId = App.contextUser.Id };


                App.mainPage.DataContext = null;
                App.mainPage.DataContext = App.contextUser;
                DataContext = null;
                SPDataGame.DataContext = null;
                DataContext = this;
                SPDataGame.DataContext = contextGame;
            }
           

        }
    }
}
