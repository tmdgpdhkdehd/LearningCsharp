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
            // 주석

            // 줄바꿈 O
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");

            // 줄바꿈 X
            Console.Write("안녕하세요");
            Console.Write("안녕하세요");
            Console.Write("안녕하세요\n");
            Console.Write("안녕하세요");

            // 정수
            int a = 1;

            // 부동소수점
            float b = 3.14159212345678901234567890f;
            double c = 3.14159212345678901234567890;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 문자
            char d = '안';

            // 문자열
            string e = "안녕하세요!!";
            Console.WriteLine(d);
            Console.WriteLine(e);

            // 논리 boolean
            bool f = false;
            bool t = true;

            Console.WriteLine(f);
            Console.WriteLine(t);

            // 문자도 쓸 수 있고 정수도 쓸 수 있고.... 등등
            var a1 = 123;
            var b1 = 3.14f;     // float
            var c1 = "안녕하세요라고 나온다";
            var d1 = true;

            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(c1);
            Console.WriteLine(d1);

            // var와 매우 유사한 object
            object obj1 = 123;
            object obj2 = 1.23;     // double
            object obj3 = true;
            object obj4 = "안녕하세요";
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);

            // 부동소수점형식과 정수형식 사이의 변환
            float aa = 0.9f;
            int bb = (int)aa;
            Console.WriteLine(bb);

            float cc = 1.1f;
            int dd = (int)cc;
            Console.WriteLine(dd);

            // 문자열 <-> 숫자
            int a2 = 123;
            string b2 = a1.ToString();      // int -> string
            Console.WriteLine(b2);
            
            float c2 = 3.14f;
            string d2 = c2.ToString();      // float -> string
            Console.WriteLine(d2);

            string e2 = "123456";
            int f2 = Convert.ToInt32(e2);       // string -> int
            Console.WriteLine(f2);

            string g2 = "1.2345";
            float h2 = float.Parse(g2);     // string -> float
            Console.WriteLine(h2);

            // 문자열찾기 메소드
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            Console.WriteLine("{0}", greeting.IndexOf("Good"));     // IndexOf(), 현재문자열내에서찾고자하는지정된문자또는문자열의위치를찾는다
            Console.WriteLine("{0}", greeting.IndexOf("o"));

            Console.WriteLine("{0}", greeting.LastIndexOf("Good"));     // LastIndexOf(), 현재문자열내에서찾고자하는지정된문자또는문자열의위치를뒤에서부터찾는다
            Console.WriteLine("{0}", greeting.LastIndexOf("o"));

            Console.WriteLine("{0}", greeting.StartsWith("Good"));      // StartsWith(), 현재문자열이지정된문자열로시작하는지를평가한다
            Console.WriteLine("{0}", greeting.StartsWith("Morning"));

            Console.WriteLine("{0}", greeting.EndsWith("Good"));        // EndsWith(), 현재문자열이지정된문자열로끝나는지를평가한다
            Console.WriteLine("{0}", greeting.EndsWith("Morning"));

            Console.WriteLine("{0}", greeting.Contains("Evening"));     // Contains(), 현재문자열이지정된문자열을포함하는지를평가한다
            Console.WriteLine("{0}", greeting.Contains("Morning"));

            Console.WriteLine("{0}", greeting.Replace("Morning", "Evening"));       // Replace(), 현재문자열에서지정된문자열이다른지정된문자열로모두바뀐새문자열을반환한다

            // 문자열 변형 메소드
            Console.WriteLine("ABC".ToLower());     // 모든 대문자를 소문자로
            Console.WriteLine("abc".ToUpper());     // 모든 소문자를 대문자로

            Console.WriteLine("Happy Friday!".Insert(5, " Sunny"));     // 지정된 위치에 지정된 문자열이 삽입된 새 문자열 반환
            Console.WriteLine("I Don't Love You.".Remove(2, 6));        // 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환

            Console.WriteLine("'{0}'", " No Spaces ".Trim());       // 앞뒤에 있는 공백을 삭제한 새 문자열을 반환
            Console.WriteLine("'{0}'", " No Spaces ".TrimStart());      // 앞에있는 공백을 삭제한 새 문자열을 반환
            Console.WriteLine("'{0}'", " No Spaces ".TrimEnd());        // 뒤에있는 공백을 삭제한 새 문자열을 반환

            // 연습문제
            Console.WriteLine("사각형의너비를입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의높이를입력하세요.");
            string height = Console.ReadLine();

            // 이곳의사각형의넓이를계산하고
            // 출력하는루틴을추가하세요
            /* 답
            int muxNum = int.Parse(width) * int.Parse(height); //string형-> int형으로
            Console.WriteLine("사각형의넓이는: {0}", muxNum);
            */
        }
    }
}
