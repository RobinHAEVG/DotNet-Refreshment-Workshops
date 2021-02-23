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

            Console.WriteLine($"Exists: {info.Exists}");
            Console.WriteLine($"Root: {info.Root}");
            Console.WriteLine($"Extension: {info.Extension}");
            Console.WriteLine($"Fullname: {info.FullName}");
            Console.WriteLine($"Creation time: {info.CreationTime}");
            Console.WriteLine($"Last Access time: {info.LastAccessTime}");
            Console.WriteLine($"Last Write time: {info.LastWriteTime}");

            DirectoryInfo subdir = info.CreateSubdirectory("subdir");
            // C:\Local\test\subdir
            DirectoryInfo parent = Directory.GetParent(dirName + "\\" + subdir.Name);
            Console.WriteLine($"\nCreated subdirectory '{subdir.Name}'");
            Console.WriteLine($"Parent is {parent.Name} which does{(parent.Exists ? "" : " not")} exist");

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
