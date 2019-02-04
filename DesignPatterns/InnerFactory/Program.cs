using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerFactory
{
    
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }
    public class Point
    {


        private double x, y;

        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }
        public class PointFactory
        {
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }

            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
            Console.ReadLine();
        }
    }
}
