using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unityCSharpStudy
{
    class Program
    {
        class Point
        {
            public int X;
            public int Y;
            
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // C#에서는 연산자를 만들 수 있음
            public static Point operator + (Point p1, Point p2)
            {
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
            }
        }
        
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(2, 1);

            Point p3 = p1 + p2;

            //Point p3 = new Point(0, 0);

            //p3.X = p1.X + p2.X;
            //p3.Y = p1.Y + p2.Y;

            Console.WriteLine("{0}, {1}", p3.X, p3.Y);
        }
    }
}
