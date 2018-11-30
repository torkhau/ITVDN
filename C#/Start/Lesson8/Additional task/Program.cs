using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a *= 5;
            b *= 5;
            c *= 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers");
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = Int32.Parse(Console.ReadLine());
            Calculate(ref a, ref b, ref c);
            Console.WriteLine($"Result a = {a}, b = {b}, c = {c}");
            Console.ReadKey();
        }
    }
}
