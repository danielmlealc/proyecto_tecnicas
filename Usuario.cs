using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Wallet> Wallets { get; set; }

        public User(string name, int age, string email, string phone)
        {
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
            Wallets = new List<Wallet>();
        }
    }

}
