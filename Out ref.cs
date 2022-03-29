using System;

namespace csharp_datatype
{
    class Program
    {
        static double Calc(ref int a, ref int b)
        { return (a+=2)* (b+=2); }

        // out 정의
        static bool Calc(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }


        static void Main(string[] args)
        {
            // ref , init required
            int x = 1;
            int y = 2;
            double ret = Calc(ref x, ref y);
            Console.WriteLine("x={0}, y={1}, ret={2}", x, y, ret);

            // out , init not required
            int c, d;
            bool bret = Calc(100, 200, out c, out d);
            Console.WriteLine("c={0}, d={1}", c, d);
        }
    }
}
