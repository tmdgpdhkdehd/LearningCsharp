using System;

namespace csharp_datatype
{
    class Program
    {
  
        static void Main(string[] args)
        {
            // 문자열
            string str1 = "SBS";
            string str2 = "Game";

            // string + string 
            string str3 = str1 + " " + str2;
            Console.WriteLine("String: {0}", str3);

            // sub string
            string s3substring = str3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);

            // char
            char ch1 = 'A';
            char ch2 = 'B';

            string str = "time world";

             // each character 
             for (int i = 0; i < str.Length; i++)
             {
                Console.WriteLine("{0}: {1}", i, str[i]);
             }

             // 문자열을 문자배열로 변환
             string str5 = "game program";
             char[] chArr = str5.ToCharArray();

             for (int i = 0; i < chArr.Length; i++)
             {
                Console.WriteLine(chArr[i]);
             }

         // 문자배열을 문자열로 변환
         char[] chArr2 = { 'A', 'B', 'C', 'D', 'E' };
         string str6 = new string(chArr2);

         Console.WriteLine(str6);

        }
    }
}
