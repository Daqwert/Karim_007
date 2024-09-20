using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CasionApp.Models
{
    public partial class Game
    {
        public SolidColorBrush ColorResult
        {
            get
            {
                if (ResultGame == 0)
                    return Brushes.Gray;
                else if (ResultGame > 0)
                    return Brushes.Green;
                else
                    return Brushes.Red;
            }
        }
    }
}
