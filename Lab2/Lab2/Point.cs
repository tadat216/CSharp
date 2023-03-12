using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Point
    {
        public int x;
        public int y;
        public Point()
        { this.x = 0; this.y = 0; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void PrintPoint(int x, int y)
        {
            Console.WriteLine("({0}, {1})", x , y);
        }
        public double Distance(Point a)
        { return Sqrt((a.x-this.x)*(a.x-this.x)+(a.y-this.y)*(a.y-this.y)); }
    }
}
