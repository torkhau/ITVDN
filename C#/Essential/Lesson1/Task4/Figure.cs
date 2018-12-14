using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        private string typeFigure;
        private Point[] points;
        public string TypeFigure
        {
            get { return typeFigure; }
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            typeFigure = "Triangle";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            typeFigure = "Tetragon";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point4;
            typeFigure = "Pentagon";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.P2 - A.P2), 2) + Math.Pow((B.P1 - A.P1), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for(int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine("Perimeter -> " + perimeter);
        }
    }
}
