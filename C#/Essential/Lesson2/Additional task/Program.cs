using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Program
    {
        class User
        {
            public readonly DateTime dateInitial;
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public byte Age { get; set; }

            public User()
            {
                dateInitial = DateTime.Now;
            }
            public User(string login, string FN, string LN, byte age)
                : this()
            {
                Login = login;
                FirstName = FN;
                LastName = LN;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            User user = new User("Alex", "Aliaksandr", "Torkhau", 34);
            Console.WriteLine($"L: {user.Login}, FN: {user.FirstName}, LN: {user.LastName}, Age: {user.Age}, DI: {user.dateInitial}");
            Console.ReadKey();
        }
    }
}
