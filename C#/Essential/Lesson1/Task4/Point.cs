using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        private int p1;
        public int P1
        {
            get { return p1; }
        }
        private int p2;
        public int P2
        {
            get { return p2; }
        }
        private string name;

        public Point(int point1, int point2, string name)
        {
            p1 = point1;
            p2 = point2;
            this.name = name;
        }
    }
}
