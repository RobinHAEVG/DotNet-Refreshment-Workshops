using System;
using System.IO;

namespace FileInfoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathAndFileName = @"C:\Local\FileInfoExample1.txt";
            FileInfo info = new FileInfo(pathAndFileName);

            using (var _ = info.Create()) { }
            
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Directory);
            Console.WriteLine(info.DirectoryName);
            Console.WriteLine(info.Exists);
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.Extension);
            Console.WriteLine(info.FullName);

            Console.WriteLine("press any key to quit.");
            Console.ReadKey();
        }
    }
}
