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
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 8, "B");
            Point C = new Point(1, 8, "C");
            Point D = new Point(8, 8, "D");
            Figure figure = new Figure(A, B, C, D);
            Console.WriteLine("Figure is - " + figure.TypeFigure);
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
