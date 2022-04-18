using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        partial class myPartialClass
        {
            public void testFunc1()
            {
                Console.WriteLine("testFunc1 Call");
            }
        }

        partial class myPartialClass
        {
            public void testFunc2()
            {
                Console.WriteLine("testFunc2 Call");
            }

        }

        static void Main(string[] args)
        {
            myPartialClass pc = new myPartialClass();
            pc.testFunc1();
            pc.testFunc2();
        }
    }
}
