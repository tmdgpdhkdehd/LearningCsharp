using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        delegate int myDelegateTwoParam(int a, int b);
     
        static void Main(string[] args)
        {
            myDelegateTwoParam add;
            add = delegate (int a, int b)
            {
                return a + b;
            };
           
            Console.WriteLine("{0}", add.Invoke(1, 2));
            
        }
    }
}
