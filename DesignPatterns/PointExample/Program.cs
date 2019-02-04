using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointExample
{
    public enum CoordinateSystem
    {
        Cartesian, 
        Polar
    }
    class Point
    {
        private double x, y;

        public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    y = a;
                    x = b;
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
