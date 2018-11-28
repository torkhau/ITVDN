using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            Console.Write("Введите радиус круга: ");
            int r = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Площадь круга с радиусом {0}, равна - {1}", r, (float)(pi*Math.Pow(r, 2)));
            Console.ReadKey();
        }
    }
}
