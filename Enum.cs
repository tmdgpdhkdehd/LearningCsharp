using System;

namespace csharp_datatype
{
    class Program
    {
        enum gameClass
        {
            lecture_C,
            lecture_CPP,
            lecture_CSharp = 5, 
        }

        static void Main(string[] args)
        {
            gameClass myClass;
            myClass = gameClass.lecture_CSharp;

            int lectID = (int)myClass;

            if (myClass == gameClass.lecture_CSharp) // enum 값을 비교하는 방법
            {
                Console.WriteLine("I choose cpp, ID: {0}", lectID);
            }

        }
    }
}
