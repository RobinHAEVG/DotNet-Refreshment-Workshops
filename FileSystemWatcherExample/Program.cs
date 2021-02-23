using System;
using System.IO;

namespace FileSystemWatcherExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Local\\";

            var fsw = new FileSystemWatcher(path);
            fsw.Filter = "*.txt";
            fsw.IncludeSubdirectories = false;
            fsw.NotifyFilter = NotifyFilters.Attributes |
                               NotifyFilters.CreationTime |
                               NotifyFilters.FileName |
                               NotifyFilters.LastAccess |
                               NotifyFilters.LastWrite |
                               NotifyFilters.Size;
            fsw.EnableRaisingEvents = true;

            fsw.Changed += new FileSystemEventHandler(OnChanged);
            fsw.Created += new FileSystemEventHandler(OnChanged);
            fsw.Deleted += new FileSystemEventHandler(OnChanged);
            fsw.Renamed += new RenamedEventHandler(OnRenamed);

            Console.ReadKey();
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("{0} renamed to {1}", e.OldFullPath, e.FullPath);
            
        }
    }
}
