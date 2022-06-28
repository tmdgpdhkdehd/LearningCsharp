using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestCSharp
{
    public abstract class Animal
    {
        public abstract void Create();      // abstract 한정자라 본문에서 선언 불가
    }

    public class Cat : Animal
    {
        public override void Create()       // abstract 한정자를 사용한 Create 메소드는 자식에서 override 키워드를 사용해 재정의해줘야 함. 안 해주면 오류!
        {
            Console.WriteLine("Cat");
        }

        public void Run()
        {
            Console.WriteLine("Cat Run");
        }
    }

    public class Dog : Animal
    {
        public override void Create()
        {
            Console.WriteLine("Dog");
        }

        public void Jump()
        {
            Console.WriteLine("Dog Jump");
        }
    }

    public class Pig : Animal
    {
        public override void Create()
        {
            Console.WriteLine("Pig");
        }

        public void Sleep()
        {
            Console.WriteLine("Pig Sleep");
        }
    }

    public class Program
    {
        static public string IsAnimalType(Animal anim)
        {
            //if (anim is Animal) return "Animal";      // Cat, Dog 모두 Animal 자식이라 Animal 출력됨
            if (anim is Cat) return "Cat";      // is 연산자는 캐스팅 성공유무만 확인 (True or False)
            if (anim is Dog) return "Dog";
            return "None";
        }

        static public void AnimalAction(Animal anim)
        {
            switch(IsAnimalType(anim))      // IsAnimalType 메소드에서 리턴된 값 (Cat, Dog, None 중 하나)
            {
                case "Cat":
                    {
                        var cat = anim as Cat;      // as 연산자는 캐스팅에 성공하면 캐스트 결과를 리턴하고 실패하면 Null 값을 리턴
                        cat.Run();
                    }
                    break;
                case "Dog":
                    {
                        var dog = anim as Dog;
                        dog.Jump();
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal pig = new Pig();
            Animal cat = new Cat();
            Cat cat2 = new Cat(); // cat이랑 무슨 차이??

            string name = IsAnimalType(cat);
            Console.WriteLine(name);        // Cat 출력

            AnimalAction(dog);      // Dog Jump 출력
            AnimalAction(pig);      // 출력 안 됨

        }
    }
}
