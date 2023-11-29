using DD_My_Money.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<SavingsAccount> Accounts { get; set; } = new List<SavingsAccount>();
        public List<CreditsCards> CreditsCards { get; set; } = new List<CreditsCards>();
        public List<Credit> Credits { get; set; } = new List<Credit>();
    }
}
