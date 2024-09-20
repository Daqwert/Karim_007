using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasionApp.Models
{
    public partial class User
    {
        public int Balance
        {
            get
            {
                int balance = 0;
                var listAmount = App.DB.Transaction.Where(x => x.UserId == Id && x.IsTopUp == true).ToList();
                var listSend = App.DB.Transaction.Where(x => x.UserId == Id && x.IsTopUp == false).ToList();
                var listGame = App.DB.Game.Where(x => x.UserId == Id).ToList();
                balance += listAmount != null ? listAmount.Select(x => x.AmountMoney).Sum() : 0;
                balance -= listSend != null ? listSend.Select(x => x.AmountMoney).Sum() : 0;
                balance += listGame != null ? listGame.Select(x => x.ResultGame).Sum() : 0;
                return balance;
            }
        }
    }
}
