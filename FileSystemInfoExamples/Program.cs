using System;
using System.IO;

namespace FileSystemInfoExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string entry in Directory.GetDirectories(@"C:\"))
            {
                DisplayFileSystemInfoAttributes(new DirectoryInfo(entry));
            }
            
            foreach (string entry in Directory.GetFiles(@"C:\"))
            {
                DisplayFileSystemInfoAttributes(new FileInfo(entry));
            }

            Console.WriteLine("press any key to quit.");
            Console.ReadKey();
        }

        private static void DisplayFileSystemInfoAttributes(FileSystemInfo fsi)
        {
            //  Assume that this entry is a file.
            string entryType = "File";

            // Determine if entry is really a directory
            if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                entryType = "Directory";
            }
            //  Show this entry's type, name, and creation date.
            Console.WriteLine("{0} entry {1} was created on {2:D}", entryType, fsi.FullName, fsi.CreationTime);
        }
    }
}
