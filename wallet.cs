using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money
{
    class Wallet
    {
        public string BankName { get; set; }
        public decimal Balance { get; set; }

        public Wallet(string bankName)
        {
            BankName = bankName;
            Balance = 0.0m;
        }
    }

}
