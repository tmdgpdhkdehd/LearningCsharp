using System;

namespace csharp_datatype
{
    class Program
    {
        public class Person
        {
            
            private string name;
            private int age;

            // Constructor
            public Person()
            {
                name = string.Empty;
                age = 0;
            }

            // 
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }

            // 메서드
            public string GetPersonInfo()
            {
                string data = string.Format("name: {0} , age: {1}", this.Name, this.Age);
                return data;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "gildong";
            person.Age = 20;

            Console.WriteLine("{0}", person.GetPersonInfo());
        }
    }
}
