using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 3; 
            var s = "Hello world"; 
            var a = new[] { 0, 1, 2, 3 }; // int array 
            var person = new { Name = "John", Age = 30 }; // 구조체 
            
            var list = new List<int>(); // List<int>
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("s={0},a[3]={1},person.name={2},list.Count={3}", s, a[3], person.Name, list.Count);
        }
    }
}
