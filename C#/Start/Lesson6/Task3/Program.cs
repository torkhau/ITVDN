using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
       static void Line(char simbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(simbol);
            };
        }

       static void Rectangle(int len, int width)
        {
            for (int i = 0; i < width; i++)
            {
                Line('*', len);
                Console.Write('\n');
            }
        }

        static void Triangle90(int width, int possition)
        {
            for (int i = 1; i <= width; i++)
            {
                if (possition == 0)
                {
                    Line('*', i);
                    Line(' ', width - i);
                }
                else
                {
                    Line(' ', width - i);
                    Line('*', i);
                };
                Console.Write('\n');
            }
        }

        static void Triangle(int width)
        {
            int DoubleWibth = width * 2;
            for (int i = 1; i <= DoubleWibth; i++)
            {
                Line(' ', DoubleWibth - i);
                Line('*', i);
                Line('*', i);
                Line(' ', DoubleWibth - i);
                Console.Write('\n');
            }
        }
        static void Rhombus(int width)
        {
            int DoubleWibth = width * 2;
            for (int i = 1; i <= DoubleWibth; i++)
            {
                Line(' ', DoubleWibth - i);
                Line('*', i);
                Line('*', i);
                Line(' ', DoubleWibth - i);
                Console.Write('\n');
            }
            for(int i = DoubleWibth - 1; i >= 1; i-- )
            {
                Line(' ', DoubleWibth - i);
                Line('*', i);
                Line('*', i);
                Line(' ', DoubleWibth - i);
                Console.Write('\n');
            }
        }

        static void Main(string[] args)
        {
            Rectangle(10, 6);
            Triangle90(7, 0);
            Triangle90(7, 1);
            Triangle(3);
            Rhombus(3);
            Console.ReadKey();
        }
    }
}
