using DD_My_Money.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_My_Money.Controllers
{
    public class UserController : User
    {
        private List<User> Users = new List<User>();

        public void Create(string name, string email, string password)
        {
            if (Users.Exists(u => u.Email == email)) // Verificar si el correo ya está registrado
            {
                Console.WriteLine("El correo ya está registrado. Por favor, elige otro.");
                return;
            }

            var newUser = new User // Crear un nuevo usuario y agregarlo a la lista de usuarios.
            {
                Name = name,
                Email = email,
                Password = password
            };

            Users.Add(newUser);
            Console.WriteLine("Usuario creado con éxito.");
        }

        public User Login(string email, string password)
        {
            User search = Users.Find(u => u.Email == email && u.Password == password);

            if (search != null)
            {
                Console.WriteLine($"¡Bienvenido, {search.Name}!");
                return search;
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas. Inténtalo de nuevo.");
                return null;
            }
        }
    }
}
