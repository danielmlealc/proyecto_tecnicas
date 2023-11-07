using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    internal class CreditsCards : Account
    {
        public decimal InterestRate { get; set; }
        public decimal HandlingFee { get; set;}
    }
}
