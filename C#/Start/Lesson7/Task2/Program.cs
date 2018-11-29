using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Add(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
        static void Sub(int num1, int num2)
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        }
        static void Mul(int num1, int num2)
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        static void Div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: divide by zero!");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / (float)num2));
            }
        }

        static bool Check(string value)
        {
            if ((value == "exit") || (value == "quit") || (value == "q") || (value == "e"))
            {
                return true;
            };
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("FOR EXIT ENTER \"exit\" or \"e\" or \"quit\" or \"q\" or close this window.");
            while (true)
            {
                int operand1 = 0, operand2 = 0;
                Console.Write("Enter operand#1: ");
                string oper = Console.ReadLine();
                if (Check(oper))
                {
                    break;
                }
                else
                {
                    operand1 = Int32.Parse(oper);
                };
                Console.Write("Enter operand#2: ");
                oper = Console.ReadLine();
                if (Check(oper))
                {
                    break;
                }
                else
                {
                    operand2 = Int32.Parse(oper);
                }
                Console.Write("Enter arithmetic operation sign (+, -, *, /): ");
                oper = Console.ReadLine();
                if (Check(oper))
                {
                    break;
                }
                switch (oper)
                {
                    case "+" :
                        Add(operand1, operand2);
                        break;
                    case "-" :
                        Sub(operand1, operand2);
                        break;
                    case "*" :
                        Mul(operand1, operand2);
                        break;
                    case "/" :
                        Div(operand1, operand2);
                        break;
                    default :
                        Console.WriteLine("Error arithmetic operation sign!!!");
                        break;
                }
            }
            Console.WriteLine("Good bye! Press any key...");
            Console.ReadKey();
        }
    }
}
