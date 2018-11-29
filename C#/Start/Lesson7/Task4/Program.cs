using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static bool IsNegative(int num)
        {
            if (num >= 0)
            {
                return false;
            };
            return true;
        }

        static bool IsSimple(int num)
        {
            if (num <= 0)
            {
                return false;
            };
            if (num <= 2)
            {
                return true;
            };
            for(int i = 3; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            };
            return true;
        }

        static bool IsDevBy2_3_5_6_9(int num)
        {
            if ((num % 2 == 0) && (num % 3 == 0) && (num % 5 == 0) && (num % 6 == 0) && (num % 9 == 0))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.Write("Enter positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number {0} is " + (IsNegative(num) ? "negative" : "positive") + ".", num);
            Console.WriteLine("Number {0} is " + (IsSimple(num) ? "" : "not ") + "simple.", num);
            Console.WriteLine("Number {0} is " + (IsDevBy2_3_5_6_9(num) ? "" : "not ") + "dev by 2, 3, 5, 6, 9.", num);
            Console.ReadKey();
        }
    }
}
