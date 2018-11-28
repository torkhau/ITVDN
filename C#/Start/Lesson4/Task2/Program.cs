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
            int operand1 = 36;
            int operand2 = 0;

            Console.Write("Введите знак арифметической операции ('+', '-', '*', '/'): ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+" :
                    Console.WriteLine("Сумма чисел {0} и {1} - равна: {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-" :
                    Console.WriteLine("Разность чисел {0} и {1} - равна: {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("Произведение чисел {0} и {1} - равна: {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Деление на 0 недопустимо, проверте правильность введённых данных.");
                        break;
                    }
                    Console.WriteLine("Деление чисел {0} и {1} - равна: {2}", operand1, operand2, operand1 / operand2);
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестную арифметическую операцию.");
                    break;
            };

            Console.ReadKey(); 
        }
    }
}
