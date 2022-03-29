using System;
using System.Collections.Generic;

namespace csharp_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            var dicTable = new Dictionary<string, string>();
            dicTable.Add("Korea", "Seoul");
            dicTable.Add("Japan", "Tokyo");
            dicTable.Add("USA", "Washington");

            string str = "USA";
            Console.WriteLine(" key: {0} \n value: {1}", str, dicTable[str]);
        }
    }
}
