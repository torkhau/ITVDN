using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 70;
            int b = 6;
            for(int i = 0; i < b; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    Console.Write("*");
                };
                Console.Write("\n");
            };
            Console.ReadKey();
        }
    }
}
