using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stack<float> st = new Stack<float>();
            st.Push(2.3f);
            st.Push(1.5f);
            st.Push(3.7f);

            Console.WriteLine(st.Pop());
        }
    }
}
