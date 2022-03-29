using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        static IEnumerable<int> GetNumber()
        {
            Console.WriteLine("aaa");
            yield return 100;  // first return

            Console.WriteLine("bbb");
            yield return 200;  // second return

            Console.WriteLine("ccc");
            yield return 300;  // third return
        }

        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
