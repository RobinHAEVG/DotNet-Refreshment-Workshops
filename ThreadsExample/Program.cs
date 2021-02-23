using System;
using System.Threading;

namespace ThreadsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(new ThreadStart(ThreadMethod)) { Name = "XZ" };
            var t2 = new Thread(new ThreadStart(ThreadMethod)) { Name = "abc" };
            t1.Start();
            t2.Start();

            Console.WriteLine("done");
            Console.ReadKey();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Thread.CurrentThread.Name + " has finished.");
        }
    }
}
