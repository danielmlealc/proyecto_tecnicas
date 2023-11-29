using DD_My_Money.Controllers;
using DD_My_Money.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DD_My_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a tu billetera virtual!");

            var UserController = new UserController();
            while (true)
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Crear un nuevo usuario");
                Console.WriteLine("2. Iniciar sesión");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CreateUser(UserController);
                        break;

                    case "2":
                        Login(UserController);
                        break;

                    case "3":
                        Console.WriteLine("Gracias por usar la billetera virtual. ¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }

        static void CreateUser(UserController userController)
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Correo Electrónico: ");
            string email = Console.ReadLine();
            Console.Write("Contraseña: ");
            string password = Console.ReadLine();

            userController.Create(name, email, password);
        }

        static void Login(UserController userController)
        {
            Console.Write("Correo Electrónico: ");
            string email = Console.ReadLine();
            Console.Write("Contraseña: ");
            string password = Console.ReadLine();

            // Intentar iniciar sesión.
            var login = userController.Login(email, password);

            // Si el inicio de sesión es exitoso, puedes realizar más acciones relacionadas con el usuario.
            if (login != null)
            {
                MenuUser(login);
            }
        }

        static void MenuUser(User user)
        {
            while (true)
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Agregar una cuenta");
                Console.WriteLine("2. Agregar una deuda");
                Console.WriteLine("3. Agregar una tarjeta de crédito");
                Console.WriteLine("4. Ver cuentas");
                Console.WriteLine("5. Ver deudas");
                Console.WriteLine("6. Ver tarjetas de crédito");
                Console.WriteLine("7. Cerrar sesión");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddAccount(user);
                        break;

                    case "2":
                        AddCredit(user);
                        break;

                    case "3":
                        AddCreaditCard(user);
                        break;

                    case "4":
                        ShowAccounts(user);
                        break;

                    case "5":
                        ShowCredits(user);
                        break;

                    case "6":
                        ShowCreditCards(user);
                        break;

                    case "7":
                        Console.WriteLine("Sesión cerrada. ¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }

        static void AddAccount(User user)
        {
            Console.Write("Nombre del banco: ");
            string bankName = Console.ReadLine();
            Console.Write("Cantidad de dinero actual en la cuenta: ");
            string balance = Console.ReadLine();

            var savingAccountController = new SavingAccountController();

            if (decimal.TryParse(balance, out decimal amount))
            {
                // Llamada a la función que espera un parámetro decimal.
                savingAccountController.Create(user, bankName, amount);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número decimal válido.");
            }
        }

        static void ShowAccounts(User user)
        {
            var savingAccountController = new SavingAccountController();
            savingAccountController.ShowAccounts(user);
        }

        static void AddCredit(User user)
        {
            var creadit = new Credit();

            Console.Write("Nombre: ");
            creadit.Entity = Console.ReadLine();
            Console.Write("Deuda: ");
            string balance = Console.ReadLine();
            decimal.TryParse(balance, out decimal amount);
            creadit.Balace = amount;
            Console.Write("Tasa de interés: ");
            string interestRate = Console.ReadLine();
            decimal.TryParse(interestRate, out decimal interest);
            creadit.InterestRate = interest;

            var creditController = new CreditController();
            creditController.Create(user, creadit);
        }

        static void ShowCredits(User user)
        {
            var creditController = new CreditController();
            creditController.ShowCredits(user);
        }

        static void AddCreaditCard(User user)
        {
            var creaditCard = new CreditsCards();

            Console.Write("Nombre: ");
            creaditCard.Name = Console.ReadLine();
            Console.Write("Entidad bancaria: ");
            creaditCard.Entity = Console.ReadLine();
            Console.Write("Cupo: ");
            string balance = Console.ReadLine();
            decimal.TryParse(balance, out decimal amount);
            creaditCard.Balace = amount;
            Console.Write("Tasa de interés: ");
            string interestRate = Console.ReadLine();
            decimal.TryParse(interestRate, out decimal interest);
            creaditCard.InterestRate = interest;
            Console.Write("Cuota de manejo: ");
            string handlingFee = Console.ReadLine();
            decimal.TryParse(handlingFee, out decimal handling);
            creaditCard.HandlingFee = handling;

            var creditCardController = new CreditCardController();
            creditCardController.Create(user, creaditCard);
        }

        static void ShowCreditCards(User user)
        {
            var creditCardController = new CreditCardController();
            creditCardController.ShowCreditsCard(user);
        }
    }
}
