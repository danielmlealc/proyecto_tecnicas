using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Model
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public List<SavingsAccount> Accounts { get; set; }
        public List<CreditsCards> CreditsCards { get; set; }
        public List<Credits> Credits { get; set; }

        public User(string nombre, string email)
        {
            Name = nombre;
            Email = email;

            Accounts = new List<SavingsAccount>();
            CreditsCards = new List<CreditsCards>();
            Credits = new List<Credit>();
        }

        public void AddAccount(SavingsAccount cuenta)
        {
            Account.Add(cuenta);
        }

        public void AddCredit(Credits deuda)
        {
            Deudas.Add(deuda);
        }

        public void AgregarTarjetaCredito(TarjetaCredito tarjeta)
        {
            TarjetasCredito.Add(tarjeta);
        }
    }
}
