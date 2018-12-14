using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 0;
            double side2 = 0;
            Console.Write("Enter first side of rectangle -> ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second side of rectangle -> ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine("Area of rectangle {0}x{1} is {2}", side1, side2, rec.Area);
            Console.WriteLine("Perimeter of rectangle {0}x{1} is {2}", side1, side2, rec.Perimeter);
            Console.ReadKey();
        }
    }
}
