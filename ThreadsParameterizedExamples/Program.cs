using System;
using System.Threading;

namespace ThreadsParameterizedExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var pm = new ParameterizedThreadStart(MyThreadMethod);
            var t1 = new Thread(pm);

            t1.Start("hey");

            Console.WriteLine("done.");
            Console.ReadKey();
        }

        private static void MyThreadMethod(object obj)
        {
            string message = (string) obj;
            Console.WriteLine($"Message: {message}");
        }
    }
}
