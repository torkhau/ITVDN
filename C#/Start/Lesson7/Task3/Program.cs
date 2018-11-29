using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static double Converte(double summ, double rate)
        {
            return summ * rate;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter summ: ");
            double summ =  Double.Parse(Console.ReadLine());

            Console.Write("Enter rate: ");
            double rate = Double.Parse(Console.ReadLine());

            Console.WriteLine("New summ: {0}", Converte(summ, rate));
            Console.ReadKey();

        }
    }
}
