using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DD_My_Money
{
    class Program
    {
        static void Main()
        {
            User user = new User("Juan", 30, "juan@email.com", "123456789");
            user.Wallets.Add(new Wallet("Nequi"));
            user.Wallets.Add(new Wallet("Daviplata"));
            user.Wallets.Add(new Wallet("Bancolombia"));
            user.Wallets.Add(new Wallet("Scotiabank"));
            user.Wallets.Add(new Wallet("BBVA"));

            foreach (Wallet wallet in user.Wallets)
            {
                wallet.Balance = 1000.0m; // Saldo inicial de 1000 en cada billetera // usar login and logout 
            }

            decimal vehiclePrice = 500.0m; // Precio del vehículo
            Simulator.BuyVehicle(user, "moto", vehiclePrice);


            Console.ReadLine();
        }
    }

}