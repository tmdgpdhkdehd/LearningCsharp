using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Mammal
    {
        public virtual void Move()      // new: 왼쪽 타입 검사, virtual: 오른쪽 타입 검사
        {
            Console.WriteLine("이동한다");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }
    class Human : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("두 발로 움직인다");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal aMammal = new Mammal();
            aMammal.Move();

            aMammal = new Lion();   // 이렇게 해놓고 출력은 Mammal이 뜬다 그래서 버츄얼을 사용
            aMammal.Move();

            aMammal = new Whale();
            aMammal.Move();

            aMammal = new Human();
            aMammal.Move();
        }
    }
}
