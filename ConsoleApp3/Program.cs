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
            double dist1_2, dist1_3, dist1_4;
            Point[] points;

            Point p1 = MakeAPoint();
            Point p2 = MakeAPoint();
            Point p3 = MakeAPoint();
            Point p4 = MakeAPoint();

            dist1_2 = Distance(p1, p2);
            dist1_3 = Distance(p1, p3);
            dist1_4 = Distance(p1, p4);

            Console.WriteLine(p1 + " " + p2 + " " + p3 + " " + p4);

            Console.WriteLine("1-->2 " + dist1_2);
            Console.WriteLine("1-->3 " + dist1_3);
            Console.WriteLine("1-->4 " + dist1_4);
            ;

            if (dist1_2 > dist1_3 && dist1_2 > dist1_4)
                Console.WriteLine("p2");

            if (dist1_3 > dist1_2 && dist1_3 > dist1_4)
                Console.WriteLine("p3");

            if (dist1_4 > dist1_3 && dist1_4 > dist1_2)
                Console.WriteLine("p4");

            Console.ReadKey();
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