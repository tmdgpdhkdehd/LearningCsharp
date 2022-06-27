using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func);
            myThread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 2);       // 서브스레드보다 얘가 더 먼저 실행됨
                Thread.Sleep(100);
            }
            Console.WriteLine("메인쓰레드 종료");      // main에서 실행이 끝나고 Func 스레드는 계속 실행됨 
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
