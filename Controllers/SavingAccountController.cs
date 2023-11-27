using DD_My_Money.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Controllers
{
    internal class SavingAccountController
    {
        public void Create(User user, string banckName, decimal balance)
        {
            // Verificar si el usuario ya tiene una cuenta del mismo tipo.
            //if (cuentasFinancieras.Exists(c => c.Titular == usuario && c.GetType() == cuenta.GetType()))
            //{
            //Console.WriteLine($"El usuario ya tiene una cuenta {cuenta.GetType().Name}.");
            //return;
            //}

            var account = new SavingsAccount();

            // Asignar el titular a la cuenta y agregarla a la lista.
            account.Entity = banckName;
            account.Balace = balance;

            user.Accounts.Add(account);

            Console.WriteLine($"Cuenta {account.Entity} agregada con éxito al usuario {user.Name}.");
        }

        public void ShowAccounts(User user)
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
                    Console.WriteLine($"{account.Entity}: Saldo: {account.Balace}");
                }
            }
        }
    }
}
