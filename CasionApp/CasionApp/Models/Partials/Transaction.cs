using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CasionApp.Models
{
    public partial class Transaction
    {
        public SolidColorBrush ColorTransaction
        {
            get
            {
                return IsTopUp ? Brushes.Green : Brushes.Red;
            }
        }
    }
}
