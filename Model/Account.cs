using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    internal class Account
    {
        public string Owner { get; set; }
        public decimal Balace { get; set; }

        public virtual void Depositar(decimal amount)
        {
            Balace += amount;
        }

        public virtual void Retirar(decimal amount)
        {
            Balace -= amount;
        }
    }
}
