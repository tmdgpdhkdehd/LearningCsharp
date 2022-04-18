using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        delegate int myDelegateTwoParam(int a, int b);
        delegate void myDelegateNoParam();

        static void Main(string[] args)
        {
            myDelegateTwoParam add = (a, b) => a + b;
            myDelegateNoParam funcNoParam = () => Console.WriteLine("no Parameter");

            Console.WriteLine("{0}", add.Invoke(1, 2));
            funcNoParam.Invoke();
        }
    }
}
