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
            // 산술 연산자
            int a = 111 + 222;      // 더하기
            Console.WriteLine("a : {a}");       // 저번에 못했던 설명
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");      // 빼기

            int c = b * 10;
            Console.WriteLine($"c : {c}");      // 곱하기

            double d = c / 6.3;
            Console.WriteLine($"d : {d}");      // 나누기 (몫)

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");      // 몫과 나머지

            Console.WriteLine();




            // 증가 감소 연산자
            int a1 = 10;
            a1++;
            // a1 = a1 + 1;
            Console.WriteLine(a1);
            a1--;
            // a1 = a1 - 1;
            Console.WriteLine(a1);

            Console.WriteLine(a1++);        // 후위 증가 연산자
            Console.WriteLine(++a1);        // 전위 증가 연산자

            a1 = 10;
            Console.WriteLine(a1--);        // 후위 감소 연산자
            Console.WriteLine(--a1);        // 전위 감소 연산자




            // 문자열 결합 연산자
            int iresult = 123 + 456;     // 산술 연산자 +
            Console.WriteLine(iresult);

            string result = "123" + "456";      // 문자열 결합 연산자 +
            Console.WriteLine(result);
            result = "Hello" + " " + "World!";
            Console.WriteLine(result);

            Console.WriteLine();

            /*
            다음 보기 중에서 결과가 다른 것을 찾으세요
            1. i = i + 1;
            2. i++;
            3. ++i;
            4. i += 1;
            답 2번
             */
        }
    }
}
