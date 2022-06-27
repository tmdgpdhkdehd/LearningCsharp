using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Program
    {
        public static IEnumerator<int> Foo()
        {
            Console.WriteLine("1");
            yield return 10;
            Console.WriteLine("2");
            yield return 20;
            Console.WriteLine("3");
            yield return 30;
            Console.WriteLine("4");
            yield return 40;
            Console.WriteLine("5");
            yield return 50;
        }
        static void Main(string[] args)
        {
            int[] ret = new int[10];
            IEnumerator<int> e = Foo();

            for (int i = 0; i < 10; i++)
            {
                e.MoveNext();
                ret[i] = e.Current;
                Console.WriteLine($"{ret[i]}");
            }
        }
    }
}
