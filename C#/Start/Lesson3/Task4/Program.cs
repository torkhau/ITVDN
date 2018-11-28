using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            Console.Write("Введите радиус цилиндра: ");
            int R = Int32.Parse(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            int h = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Объём цилиндра с радиусом {0} и высотой {1}, равен - {2}", R, h, (float)(pi * Math.Pow(R, 2) * h));
            Console.WriteLine("Площадь поверхности цилиндра с радиусом {0} и высотой {1}, равена - {2}", R, h, (float)(2 * pi * R * (R + h)));

            Console.ReadKey();
        }
    }
}
