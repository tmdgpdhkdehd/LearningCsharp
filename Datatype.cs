using System;

namespace csharp_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool
            bool b = true;  

            // Numeric
            short sh = -10000;
            int i = 1000000;
            long l = 1234L;      // long
            float f = 123.45F;   // float
            double d1 = 123.45;
            double d2 = 123.45D; // double

            char ch = 'C';
            string str = "Hello";

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2020, 10, 24, 12, 50, 0);

            Console.WriteLine("{0} \n{1} \n{2}", str, dt, d2);
        }
    }
}
