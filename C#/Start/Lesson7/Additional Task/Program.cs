using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Calculate(int num1, int num2, int num3)
        {

            Console.WriteLine("({0} + {1} + {2})/3 = {3}", num1, num2, num3, (num1 + num2 + num3)/3.0f);

        }
        static void Main(string[] args)
        {
            Calculate(1, 7, 54);
            Console.ReadKey();
        }
    }
}
