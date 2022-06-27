using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Animal
    {
        public string name = "몰라";

        public Animal()
        {
            Console.WriteLine($"Animal 생성자");
        }
        public void printAnimal(string name)
        {
            Console.WriteLine($"Animal의 이름은 {name}입니다.");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine($"Dog 생성자");
        }

        public void printDog(string name)
        {
            base.name = name;
            Console.WriteLine($"Dog의 이름은 {name}입니다.");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine($"Cat 생성자");
        }

        public void printCat()
        {
            Console.WriteLine($"Cat의 이름은 {base.name}입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("--------------");
            Dog dog = new Dog();
            Console.WriteLine("--------------");
            dog.printDog("삐삐");
            Console.WriteLine("--------------");

            Cat cat = new Cat();
            Console.WriteLine("--------------");
            animal.printAnimal("아무튼 동물");
            Console.WriteLine("--------------");
            cat.printCat();
        }
    }
}
