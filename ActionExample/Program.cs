using System;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Action myAction = delegate { Console.WriteLine("hallo"); };

            Action<string> msg = Print;
            
            if (msg != null)
            {
                msg("Hello world!");
            }

            // you can shorten the null check with this
            // it is functionally equivalent
            msg?.Invoke("Hello world!");

            Console.ReadKey();
        }

        private static void MyVoidMethod()
        {
            Console.WriteLine("hey");
        }

        static void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
