using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CasionApp.Models
{
    public partial class RoundGame
    {
        public SolidColorBrush ColorWin
        {
            get
            {
                return ResultMoney > 0 ? Brushes.Green : Brushes.Red;
            }
        }
        public SolidColorBrush ColorNumber
        {
            get
            {
                if (ResultNumber == 0)
                    return Brushes.Green;
                else if (ResultNumber % 2 == 0)
                    return Brushes.Black;
                else
                    return Brushes.Red;
            }
        }
    }
}
