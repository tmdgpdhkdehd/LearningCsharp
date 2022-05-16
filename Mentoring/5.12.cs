using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public class CPythagoras
        {
        }
        static void Main(string[] args)
        {
            int a;

            string input = Console.ReadLine();
            a = Int32.Parse(input);

            Console.WriteLine(a);

            if (a < 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("a는 음수고 짝수다");
                }
                else
                {
                    Console.WriteLine("a는 음수고 홀수다");
                }
            }
            else if (a > 0)
            {
                Console.WriteLine("양수");
            }
            else
                Console.WriteLine("0");

            switch(a)
            {
                case 1:
                    break;
                    Console.WriteLine("1");
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("나머지 수");
                    break;
            }

            switch(a)
            {
                case 90:
                    Console.WriteLine("아주 좋은 점수");
                    break;
                case 80:
                    Console.WriteLine("좋은 점수");
                    break;
                case 70:
                    Console.WriteLine("평범한 점수");
                    break;
                case 60:
                    Console.WriteLine("아쉬운 점수");
                    break;
                case 50:
                    Console.WriteLine("낮은 점수");
                    break;
                default:
                    Console.WriteLine("쓰레기 점수");
                    break;
            }

            if ((90 < a) && (a < 100))
            {
                Console.WriteLine("아주 좋은 점수");
            }
        }
    }
}
