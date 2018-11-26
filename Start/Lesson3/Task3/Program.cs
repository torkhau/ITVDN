using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Среднее арифметическое чисел {0}, {1}, {2}, число - {3}", a, b, c, (float)(a + b + c)/3);
            Console.ReadKey();
        }
    }
}
