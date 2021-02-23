using System;
using System.IO;

namespace DriveInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine($"Drive {d.Name}");
                Console.WriteLine($"  Drive type: {d.DriveType}");
                if (d.IsReady)
                {
                    Console.WriteLine($"  Volume label: {d.VolumeLabel}");
                    Console.WriteLine($"  File system: {d.DriveFormat}");
                    Console.WriteLine("  Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                    Console.WriteLine("  Total available space:          {0, 15} bytes", d.TotalFreeSpace);
                    Console.WriteLine("  Total size of drive:            {0, 15} bytes ", d.TotalSize);
                }
            }

            Console.ReadKey();
        }
    }
}
