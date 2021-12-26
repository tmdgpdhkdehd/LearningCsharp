using System;

namespace UnityCsharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수는 RAM에 저장
            // 코드-연산자,제어-반복문은 CPU에 저장

            int number;         // 4바이트 할당. -2147483648 ~ 2147483647 범위
            number = 100;
            Console.WriteLine(number);

            char ch;            // 보통 1바이트 할당인데 C#은 2바이트 할당. a~z, A~Z, ascii 쓸 수 있음
            ch = 'a';
            string str1;
            str1 = "hello ?";
            string str2;
            str2 = "철수";
            string str3;
            str3 = str1 + "\n" + str2 + ch;         // +로 붙임. \n 줄바꿈
            Console.WriteLine(str3);

            // char[] myCharArray = { 'B', 'T', 'S' };
            int[] numbers = { 3, 2, 1, 4, 5, 9 };           // 4바이트가 6개
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            sum = 2 * (1 + 2);          // 연산자 우선순위 Ex) 1.() 2.+ 3.* 4.=
            Console.WriteLine(sum);

            bool isA = true;
            bool isB = !isA;            // !는 NOT. 반대로 바꿈
            Console.WriteLine(isB);

            int n = 0;
            n++;            // ++ 단항연산자 +1
            Console.WriteLine(n);
            n--;            // -- 단항연산자 -1
            Console.WriteLine(n);

            float f1 = 1.222222f;
            int n1 = (int)f1;           // float을 int형식으로 변환
            Console.WriteLine(n1);

            int siz = sizeof(char);
            Console.WriteLine(siz);

            int n2 = 10 % 3;            // % 나머지
            Console.WriteLine(n2);

            int n3 = 3;
            int n4 = 2;
            bool isBigger = n3 >= n4;           // 비교연산자 > >= < <=
            Console.WriteLine(isBigger);

            isBigger = n3 == n4;            // 등가연산자 == !=
            Console.WriteLine(isBigger);

            isA = true;
            isB = false;
            bool isC = isA && isB;          // 논리 연산자 && ||
            Console.WriteLine(isC);

            int a = 3;
            int b = 2;
            string 스마트폰사줘말어 = a > b ? "사줌" : "안사줌";         // a > b가 true면 사줌 false면 안사줌. 조건(삼항)연산자 ?:
            Console.WriteLine(스마트폰사줘말어);

            a = 2;
            a += 3;         // a = a + 3; 축약형대입연산자 += -= *= /= %=
            Console.WriteLine(a);
        }
    }
}
