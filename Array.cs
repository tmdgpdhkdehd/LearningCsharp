using System;

namespace csharp_datatype
{
    class Program
    {
  
        static void Main(string[] args)
        {
            // 1차 배열
            string[] name = new string[10];
            string[] lecture = { "알고리즘", "데이터구조", "게임수학" };

            // 2차 배열
            string[,] employee = { { "홍길동", "경리부" }, { "김철수", "총무부" } };

           
            // 2차 배열 
            int[][] Arr = new int[3][];

            Arr[0] = new int[2];
            Arr[1] = new int[3] { 1, 2, 3 };
            Arr[2] = new int[4] { 1, 2, 3, 4 };

            Arr[0][0] = 1;
            Arr[0][1] = 2;

            int sum = 0;
            int[] numbers = { 80, 23, 32, 45, 30 };
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            //Console.WriteLine("{0} \n{1} \n{2}", str, dt, d2);
        }
    }
}
