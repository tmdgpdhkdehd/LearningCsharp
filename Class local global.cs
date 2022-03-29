using System;

namespace csharp_datatype
{
    class Program
    {
        class CTest
        {
            int v1;
            const int MAX1 = 1024; // 초기화 안해보기
            readonly int Max2 = 100;

            public void Func()
            {  
                int local_v;
                local_v = 10; // 커멘트 막아보기

                //Max2 = 1000; // 값 변경 해보기 

                Console.WriteLine(v1);
                Console.WriteLine(local_v);
            }
        }

        static void Main(string[] args)
        {
            // 테스트
            CTest obj = new CTest();
            obj.Func();

            //Console.WriteLine("{0} \n{1} \n{2}", str, dt, d2);
        }
    }
}
