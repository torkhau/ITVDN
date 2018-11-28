using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static uint Factorial(uint n)
        {

            if (n == 0)
            {
                return 1;
            };
            uint res = 1;
            do
            {
                res *= n;
                n--;
            }
            while (n > 1);
            return res;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint n = UInt32.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, Factorial(n));
            Console.ReadKey();
        }
    }
}
