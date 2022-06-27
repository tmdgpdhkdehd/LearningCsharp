using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 백그라운드 스레드. 메인스레드가 종료되면 서브스레드도 종료됨
namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func);
            myThread.IsBackground = true;
            myThread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
            Console.WriteLine("메인쓰레드 종료");
        }
        private static void Func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
        }
    }
}
