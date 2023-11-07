using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    internal class Credit : Account
    {
        public Account Account { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
    }
}
