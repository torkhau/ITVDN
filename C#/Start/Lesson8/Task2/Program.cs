using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        const ushort debt = 700;

        static void Res(ushort payment)
        {
            int dev = debt - payment;
            if (dev > 0)
            {
                Console.WriteLine($"Debt balance is {dev}");
            }
            else if (dev < 0)
            {
                Console.WriteLine($"Overpayment amount is {-1*dev}");
            }
            else
            {
                Console.WriteLine("Debt repaid");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter payment: ");
            ushort payment = Convert.ToUInt16(Console.ReadLine());
            Res(payment);
            Console.ReadKey();
        }
    }
}
