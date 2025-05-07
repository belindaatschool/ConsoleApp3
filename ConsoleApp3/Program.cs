using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = MakeAPoint();
            Point p2 = MakeAPoint();
            Point p3 = MakeAPoint();
            Point p4 = MakeAPoint();
            Point p5 = MakeAPoint();
            Point p6 = MakeAPoint();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);
        }
        public static Point MakeAPoint()
        {
            Console.WriteLine("Enter x between 1 and 10:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y between 1 and 10:");
            int y1 = int.Parse(Console.ReadLine());

            Point p1 = new Point(x1, y1);

            return p1;
        }

        public static double Distance(Point p1, Point p2)
        {
            int x1, x2, y1, y2;

            x1 = p1.GetX();
            y1 = p1.GetY();

            x2 = p2.GetX();
            y2 = p2.GetY();

            double distance = Math.Sqrt(
                    Math.Pow(x1 - x2, 2) 
                    +
                    Math.Pow(y1 - y2, 2)
                );

            return distance;
        }
    }
}
