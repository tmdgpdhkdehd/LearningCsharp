using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 관계 연산자
            bool bresult;
            bresult = 3 > 4;
            Console.WriteLine($"3 > 4 : {bresult}");
            bresult = 3 >= 4;
            Console.WriteLine($"3 >= 4 : {bresult}");
            bresult = 3 < 4;
            Console.WriteLine($"3 < 4 : {bresult}");
            bresult = 3 <= 4;
            Console.WriteLine($"3 <= 4 : {bresult}");
            bresult = 3 == 4;
            Console.WriteLine($"3 == 4 : {bresult}");
            bresult = 3 != 4;
            Console.WriteLine($"3 != 4 : {bresult}");

            // 논리 연산자
            int a2 = 3;
            int b2 = 4;
            Console.WriteLine("&& 테스트");
            bool c2 = a2 < b2 && b2 < 5;        // &&논리곱 (참과 참)
            Console.WriteLine($"참과 참 : {c2}");
            c2 = a2 > b2 && b2 > 5;     // &&논리곱 (거짓과 거짓)
            Console.WriteLine($"거짓과 거짓 : {c2}");
            c2 = a2 < b2 && b2 > 5;     // &&논리곱 (참과 거짓)
            Console.WriteLine($"참과 거짓 : {c2}");
            c2 = a2 > b2 && b2 < 5;     // &&논리곱 (거짓과 참)
            Console.WriteLine($"거짓과 참 : {c2}");

            Console.WriteLine("|| 테스트");
            c2 = a2 < b2 || b2 < 5;        // ||논리곱 (참과 참)
            Console.WriteLine($"참과 참 : {c2}");
            c2 = a2 > b2 || b2 > 5;     // ||논리곱 (거짓과 거짓)
            Console.WriteLine($"거짓과 거짓 : {c2}");
            c2 = a2 < b2 || b2 > 5;     // ||논리곱 (참과 거짓)
            Console.WriteLine($"참과 거짓 : {c2}");
            c2 = a2 > b2 || b2 < 5;     // ||논리곱 (거짓과 참)
            Console.WriteLine($"거짓과 참 : {c2}");

            Console.WriteLine("! 테스트");
            c2 = !true;     // !부정 (참)
            Console.WriteLine($"참을 부정 : {c2}");
            c2 = !false;     // !부정 (거짓)
            Console.WriteLine($"거짓을 부정 : {c2}");

            /* 연산자 우선순위
             * 0. 소괄호로 묶어준 것 ()
             * 1. 증가 감소 연산자 (후위)
             * 2. 증가 감소 연산자 (전위)
             * 3. 산술 연산자 (* / %), 논리 연산자 (!)
             * 4. 산술 연산자 (+ -)
             * 5. 관계 연산자 (< > <= >=)
             * 6. 관계 연산자 (== !=)
             * 7. 논리 연산자 (&&)
             * 8. 논리 연산자 (||)
             */
        }
    }
}
