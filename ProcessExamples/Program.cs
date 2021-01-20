using System;
using System.Diagnostics;

namespace ProcessExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathAndFileName = @"C:\Local\test.txt";
            Process.Start("notepad.exe", pathAndFileName);

            Console.WriteLine("Hello World!");
        }
    }
}
