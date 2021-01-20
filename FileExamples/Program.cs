using System;
using System.IO;

namespace FileExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathAndFileName = @"C:\Local\FileExample.txt";
            File.WriteAllText(pathAndFileName, "Das ist der String-Inhalt.");

            string otherFile = @"C:\Local\copied_file.md";
            File.Copy(pathAndFileName, otherFile);

            File.Delete(otherFile);

            if (File.Exists(pathAndFileName))
                Console.WriteLine("Ja, die Datei existiert");

            //File.Encrypt(pathAndFileName);

            using FileStream handle = File.Create(@"C:\Local\stream_file.txt");
            {
                handle.WriteByte(40);
                handle.WriteByte(61);
                handle.WriteByte(62);
                handle.Flush();
            }

            using StreamWriter ct = File.CreateText(@"C:\Local\create_text.txt");
            {
                ct.WriteLine("hey");
                ct.WriteLine("hey");
                ct.WriteLine("hey");
                ct.WriteLine("hey");
                ct.Flush();
            }

            string[] lines = new string[] { "\nHallo", "du da", "hau ab, du"};
            File.AppendAllLines(pathAndFileName, lines);


            FileAttributes attr = File.GetAttributes(pathAndFileName);
            Console.WriteLine((attr & FileAttributes.Directory) != 0);
            Console.WriteLine((attr & FileAttributes.Compressed) != 0);
            Console.WriteLine((attr & FileAttributes.Encrypted) != 0);

            Console.WriteLine(File.GetCreationTime(pathAndFileName));
            Console.WriteLine(File.GetLastAccessTime(pathAndFileName));
            File.SetLastWriteTime(pathAndFileName, DateTime.Now.Subtract(TimeSpan.FromDays(40)));
            Console.WriteLine(File.GetLastWriteTime(pathAndFileName));

            StreamReader reader = File.OpenText(pathAndFileName);
            string line;
            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                i++;
                Console.WriteLine($"Zeile {i}: {line}");
            }


            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
