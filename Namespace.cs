using System;

namespace csharp_datatype
{
    class Program
    {
        public class CPythagoras
        {
            public double Calculate(double a, double b)
            {
                double sum = a * a + b * b;
                return Math.Sqrt(sum); // using system 막아보기 
            }
        }

        static void Main(string[] args)
        {
            CPythagoras calc = new CPythagoras();
            double len = calc.Calculate(3, 4);

            Console.WriteLine("len = {0}", len);
        }
    }
}
