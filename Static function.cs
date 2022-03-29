using System;

namespace csharp_datatype
{
    class Program
    {
        public class TestClass
        {
            private int num = 10;

            // 인스턴스 메서드
            public int Func()
            {
                return num;
            }

            // 정적(Static) 메서드
            public static int FuncStatic()
            {
                return 1000;
            }
        }

        static void Main(string[] args)
        {
            // 인스턴스 메서드 호출
            TestClass classInst = new TestClass();
            int n1 = classInst.Func();
            Console.WriteLine("{0}", n1);

            // 정적 메서드 호출
            int n2 = TestClass.FuncStatic();
            Console.WriteLine("{0}", n2);
        }
    }
}
