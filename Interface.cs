using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        interface IShape
        {
            void Draw();
        }
        class Line : IShape
        {
            public void Draw() { Console.WriteLine("this is a Line"); }
        }
        class Rectangle : IShape
        {
            public void Draw() { Console.WriteLine("this is a Rectangle"); }
        }

        static void Main(string[] args)
        {
            IShape[] instance = new IShape[] { new Line(), new Rectangle() };
            foreach (IShape item in instance)
            {
                item.Draw(); 
            }
        }
    }
}
