using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestCSharp
{
    public class Singleton
    {
        //싱글톤 객체를 static 변수로 선언
        private static Singleton instance;
        private int msg;

        //외부에서 생성자 호출 막기
        private Singleton(int msg)
        {
            this.msg = msg;
        }

        //인스턴스를 전달
        public static Singleton getInstance(int msg)
        {
            if (instance == null)       // 비어있지 않으면 첫번째 instance를 계속 사용 
            {
                instance = new Singleton(msg);
            }
            return instance;
        }

        public void printMsg()
        {
            Console.WriteLine(msg);
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Singleton instance = Singleton.getInstance(1);
            Singleton instance2 = Singleton.getInstance(2);
            instance.printMsg();
            instance2.printMsg();
        }
    }
}
