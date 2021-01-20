using System;
using System.IO;

namespace DirectoryInfoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Local\test";
            DirectoryInfo info = new DirectoryInfo(dirName);

            Console.WriteLine(info.Root);
            Console.WriteLine(info.Extension);
            Console.WriteLine(info.FullName);
            Console.WriteLine(info.CreationTime);

            DirectoryInfo subdir = info.CreateSubdirectory("subdir");

            DirectoryInfo parent = Directory.GetParent(Path.Combine(dirName, "subdir"));
            Console.WriteLine($"\nParent is {parent.Name} which does{(parent.Exists ? "" : " not")} exist");

            Console.WriteLine($"\nDirectories:");
            foreach (string dir in Directory.EnumerateDirectories(dirName))
            {
                Console.WriteLine($"\t{dir}");
            }
            Console.WriteLine($"\nFiles:");
            foreach (string file in Directory.EnumerateFiles(dirName))
            {
                Console.WriteLine($"\t{file}");
            }
            Console.WriteLine($"\nFileSystemEntries:");
            foreach (string entry in Directory.EnumerateFileSystemEntries(dirName))
            {
                Console.WriteLine($"\t{entry}");
            }

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
