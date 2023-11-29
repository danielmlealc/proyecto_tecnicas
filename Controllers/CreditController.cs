using DD_My_Money.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Controllers
{
    internal class CreditController
    {
        public void Create(User user, Credit credit)
        {
            user.Credits.Add(credit);

            Console.WriteLine($"Deuda {credit.Entity} agregada con éxito al usuario {user.Name}.");
        }

        public void ShowCredits(User user)
        {
            if (user.Credits.Count == 0)
            {
                Console.WriteLine($"El usuario {user.Name} no tiene cuentas financieras registradas.");
            }
            else
            {
                Console.WriteLine($"Cuentas financieras de {user.Name}:");
                foreach (var account in user.Credits)
                {
                    Console.WriteLine($"{account.Entity} - Deuda: {account.Balace}");
                }
            }
        }
    }
}
