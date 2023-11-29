using DD_My_Money.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Controllers
{
    internal class CreditCardController
    {
        public void Create(User user, CreditsCards card)
        {
            user.CreditsCards.Add(card);

            Console.WriteLine($"Tarjeta de crédito {card.Entity} agregada con éxito al usuario {user.Name}.");
        }

        public void ShowCreditsCard(User user)
        {
            if (user.Accounts.Count == 0)
            {
                Console.WriteLine($"El usuario {user.Name} no tiene cuentas financieras registradas.");
            }
            else
            {
                Console.WriteLine($"Cuentas financieras de {user.Name}:");
                foreach (var account in user.Accounts)
                {
                    Console.WriteLine($"{account.Entity} - Saldo: {account.Balace}");
                }
            }
        }
    }
}
