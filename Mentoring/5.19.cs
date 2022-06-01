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
            // if문 복습 (문자열로)
            string str;
            str = Console.ReadLine();
            if (str == "문자")
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }


            // 반복문은 특정 조건을 만족하는 동안 코드 또는 코드 블록을 반복해서 실행하도록 하는 문장
            // 반복문 종류: while, do while, for, foreach
            // foreach문은 패스

            // while (조건식)
            //      반복실행할_코드
            // while문은 조건식이 참인 동안 코드를 반복 실행하는데 조건식이 거짓인 값을 갖지 못하면 무한 반복된다

            int a = 10;
            while (a > 0)
            {
                Console.WriteLine(a--); //매 반복마다 a를 출력한 후 1씩 감소시킵니다
            }

            // do
            //      반복실행할_코드_블록
            // while (조건식);
            // do while 문은 while문과 유사한 반복문이지만 while 문이 조건식을 평가한 후
            // 그 결과가 참이면 코드를 실행하는데 반해 do while문은 조건식을 평가하기 전에 무조건 처음 한 번은 코드를 실행한다는 점이 다릅니다
            // do while 문은 끝에 세미콜론을 반드시 붙여줘야 합니다

            int b = 10;
            do
            {
                Console.WriteLine(b--);
            }
            while (b > 0);

            do
            {
                Console.WriteLine(b--); // 0이 출력됨
            }
            while (b > 0);

            // for (초기화식; 조건식; 반복식)
            //      반복실행할_코드
            // for문도 while문처럼 조건식이 참인동안 코드를 반복 실행하지만 while문보다 반복을 더 정교하게 제어할 수 있다
            // 초기화식: 반복을  실행하기 전에 가장 먼저, 딱 한 번만 실행되는 코드
            // 조건식: 반복을 계속 수행할지 결정하는 식, flase가 되면 반복을 중단
            // 반복식: 반복이 끝날 때마다 실행, 주로 조건식에서 사용하는 변수의 값을 조정, 반복식이 실행된 후에는 조건식이 실행되어 반복을 계속 진행할지를 판단

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            // while문에 비하면 더 많은 코드가 있긴 하지만 임의의 횟수만큼 반복을 수행하기에는 for문이 더 편리

            // for문은 if 문처럼 2개 정도는 자주 중첩해서 사용한다
            // for (초기화식; 조건식; 반복식)
            //      for (초기화식; 조건식; 반복식)
            //              반복실행할_코드

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
