using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enrer word about weather on russian: ");
            string word = Console.ReadLine().ToUpper();
            switch (word)
            {
                case "ЖАРА" :
                case "ЗНОЙ" :
                    Console.WriteLine("From russian to english - heat");
                    break;
                case "ТЁПЛЫЙ" :
                    Console.WriteLine("From russian to english - warm");
                    break;
                case "СОЛНЕЧНЫЙ" :
                    Console.WriteLine("From russian to english - sunny");
                    break;
                case "ХОЛОДНЫЙ":
                    Console.WriteLine("From russian to english - cold");
                    break;
                case "МОРОЗНЫЙ":
                    Console.WriteLine("From russian to english - frosty");
                    break;
                case "ШТОРМ":
                    Console.WriteLine("From russian to english - storm");
                    break;
                case "ТЁМНЫЙ":
                    Console.WriteLine("From russian to english - dark");
                    break;
                case "РОСА":
                    Console.WriteLine("From russian to english - dew");
                    break;
                case "ТУМАН":
                case "ДЫМКА":
                    Console.WriteLine("From russian to english - mist");
                    break;
                case "ДОЖДЬ":
                    Console.WriteLine("From russian to english - rain");
                    break;
                default :
                    Console.WriteLine("This word unknown.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
