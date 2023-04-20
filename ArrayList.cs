using System;
using System.Collections;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList는 List와 달리 여러 가지 자료형을 넣을 수 있다.
            // 단점은 느리다!
            ArrayList al = new ArrayList();

            al.Add(1);
            al.Add("Hello");
            al.Add(3.3);
            al.Add(true);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
