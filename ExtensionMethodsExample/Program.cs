using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsExample
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\\Local\\MyPath\\important_file.txt";
            string justTheFileName = filename.GetRawFileName();
            Console.WriteLine(justTheFileName);

            Person ich = new Person() {Name = "Jonas"};

            string result = ich.KlebRobinDran();
            Console.WriteLine(result);

            var namensListe = new List<string>() {"Christian", "Jonas"};
            var umgekehrt = namensListe.Umdrehen();
            foreach (string s in umgekehrt)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }

    static class Extensions
    {
        public static IEnumerable<T> Umdrehen<T>(this IEnumerable<T> l)
        {
            return l.Reverse();
        }

        public static string KlebRobinDran(this Person p)
        {
            return p.Name + " Robin!";
        }

        public static string GetRawFileName(this string s)
        {
            string[] parts = s.Split('\\');
            return parts[^1];
        }

        public static string AddiereRobin(this string s)
        {
            return "Robin! " + s;
        }
    }
}
