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
                //Directory.CreateDirectory(directoryPath);
                Console.WriteLine("directory was created");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("yes, the directory exists");
            

            Console.WriteLine(Directory.GetLastAccessTime(directoryPath));
            Console.WriteLine(Directory.GetLastWriteTime(directoryPath));

            Console.WriteLine($"\nGetFiles array length:");
            Console.WriteLine(Directory.GetFiles(directoryPath).Length);

            Console.WriteLine("press any key to quit.");
            Console.ReadKey();
        }
    }
}
