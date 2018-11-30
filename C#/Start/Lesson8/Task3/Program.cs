using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static uint Fact(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 3)
            {
                return n;
            }
            return n * Fact(--n);
        } 
        static void Main(string[] args)
        {
            Console.Write("Enter count of clients: ");
            uint n = UInt32.Parse(Console.ReadLine());
            Console.WriteLine($"Count paths is {Fact(n)}");
            Console.ReadKey();
        }
    }
}
