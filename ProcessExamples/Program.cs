using System;
using System.Diagnostics;
using System.Threading;

namespace ProcessExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. basic example
            Process.Start("mspaint.exe");

            // 2. using an overload to supply arguments.
            // This opens the file test.txt in notepad, if it exists
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.google.com/");
            
            // 3. using ProcessStartInfo
            // This loads the google start page in chrome.
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"notepad.exe",
                Arguments = @"C:\Local\test.txt",
                CreateNoWindow = true,
                UseShellExecute = false,
            };
            Process process = new Process()
            {
                StartInfo = psi,
            };
            process.Start();
            Thread.Sleep(5000);
            process.Kill();

            Console.WriteLine("Hello World!");
        }
    }
}
