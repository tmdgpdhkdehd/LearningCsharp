using System;

namespace csharp_datatype
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] array = new string[] { "AAA", "BBB", "CCC", "DDD", "EEE" };

            for (int i = 0; i < 5; i++)
                Console.WriteLine("for문 {0}", array[i]);

            // foreach 루프
            foreach (string s in array)
            {
                Console.WriteLine("foreach문 {0}", s);
            }
        }
    }
}
