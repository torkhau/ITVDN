using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number bigger 0 and lower 100: ");
            int number = Int32.Parse(Console.ReadLine());

            if ((0 <= number) && (number <= 100))
            {
                Console.WriteLine("Segments: [0 - 14] [15 - 35] [36 - 50] [50 - 100]");
                Console.Write("Number {0} in ", number);
                if ((0 <= number) && (number <= 14))
                {
                    Console.WriteLine("first segment.");
                }
                else if ((15 <= number) && (number <= 35))
                {
                    Console.WriteLine("second segment.");
                }
                else if ((36 <= number) && (number <= 50))
                {
                    Console.WriteLine("third segment.");
                }
                else if ((51 <= number) && (number <= 100))
                {
                    Console.WriteLine("fourth segment.");
                }
            }
            else
            {
                Console.WriteLine("You number not in segment [0..100]");
            }
            Console.ReadKey();
        }
    }
}
