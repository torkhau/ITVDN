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
            int a = 0;
            int b = 100;
            int summ = 0;
            int с = ++a;
            while (с < b)
            {
                summ += с;
                с++;
            };
            Console.WriteLine("Summ  - {0}", summ);
            for(int i = ++a; i < b; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
