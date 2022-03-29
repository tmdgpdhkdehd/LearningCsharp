using System;

namespace csharp_datatype
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("사용법: MyApp.exe /L /V");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/V":
                    Console.WriteLine("version 1.0 \n");
                    break;
                case "/L":
                    Console.WriteLine("Log Enabled \n");
                    break;
                default:
                    Console.WriteLine("모르는 옵션 : {0}", option);
                    break;
            }
        }
    }
}
