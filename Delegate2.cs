using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {

        static void OnPlus(int num)
        {
            int result = num + 1;
            Console.WriteLine("OnPlus : {0}", result);
        }

        static void OnPower(int num)
        {
            int result = num * num;
            Console.WriteLine("OnPower : {0}", result);
        }

        
        // 델리게이트에 연결할 함수의 원형 정의
        delegate void CalNumDelegate(int num);

        static void Main(string[] args)
        {

            // 델리게이트 변수 선언
            CalNumDelegate calc;

            calc = OnPlus;
            calc(4);

            calc = OnPower;
            calc(5);

            Console.WriteLine("---------------");
            calc -= OnPlus;
            calc -= OnPower;

            calc += OnPlus;
            calc += OnPower;
            calc(2);
        }
    }
}
