using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();

            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Insert(1, "grape");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            int[] arr = new int[3];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 5;

            List<int> list = new List<int>(arr);
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("count = {0}",list.Count);
        }
    }
}
