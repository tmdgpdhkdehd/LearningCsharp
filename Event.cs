using System;

namespace csharp_datatype
{
    class Program
    {
        class MyKeyboard
        {
            public string Text;
            // 이벤트 정의
            public event EventHandler keyPress;

            public void keyboradDown()
            {
                if (this.keyPress != null)
                {
                    // call event handler
                    keyPress(this, EventArgs.Empty);
                }
            }
        }


        static void EnterKey_Pressed(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Key Pressed");
        }

        static void Main(string[] args)
        {
            MyKeyboard btn = new MyKeyboard();

            // set event funtion
            btn.keyPress += new EventHandler(EnterKey_Pressed);  
            btn.Text = "Run";

            Console.WriteLine("Press Enter Key \n");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                btn.keyboradDown();
        }
    }
}
