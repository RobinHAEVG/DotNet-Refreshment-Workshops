using System;
using System.IO;

namespace DirectoryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Local";

            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("no, directory does not exist");
                Directory.CreateDirectory(directoryPath);
            }
            else
            {
                Console.WriteLine("yes, the directory exists");
            }

            Console.WriteLine(Directory.GetLastAccessTime(directoryPath));
            Console.WriteLine(Directory.GetLastWriteTime(directoryPath));

            Console.WriteLine($"\nGetFiles array length:");
            Console.WriteLine(Directory.GetFiles(directoryPath).Length);
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                Console.WriteLine($"Found file: {file}");
            }

            Console.WriteLine("press any key to quit.");
            Console.ReadKey();
        }
    }
}
