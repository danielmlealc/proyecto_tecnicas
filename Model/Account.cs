using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    public class Account
    {
        public string Entity { get; set; }
        public decimal Balace { get; set; }

        public virtual void AddMoney(decimal amount)
        {
            Balace += amount;
        }

        public virtual void RemoveMoney(decimal amount)
        {
            Balace -= amount;
        }
    }
}
