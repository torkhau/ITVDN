using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer first = new Printer(ConsoleColor.Cyan);
            first.Print("Черноиван Анна Вячеславовна - Doctor degree");

            PrintChild second = new PrintChild(ConsoleColor.DarkMagenta);
            second.Print("Торхов Александр Григорьевич - ЦАРЬ");

            Console.ReadKey();
        }
    }
}
