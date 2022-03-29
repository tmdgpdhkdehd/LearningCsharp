using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        delegate int MyDelegateFunc(string s);

        static int StrToInt(string s)
        {
            return int.Parse(s);
        }


        static void Main(string[] args)
        {
            MyDelegateFunc AA = new MyDelegateFunc(StrToInt);
            int i = AA("123");

            Console.WriteLine("str to int : {0}", i);
        }
    }
}
