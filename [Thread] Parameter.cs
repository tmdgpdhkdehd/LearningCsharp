using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 스레드에 매개변수 전달
namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func);
            myThread.Start(7);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("메인쓰레드 종료");
        }
        private static void Func(object obj)        // int는 안 됨 
        {
            int num = (int)obj;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
