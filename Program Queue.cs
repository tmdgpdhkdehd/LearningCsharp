using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(11);
            q.Enqueue(12);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

        }
    }
}
