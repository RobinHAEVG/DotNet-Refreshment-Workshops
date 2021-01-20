using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Person { }
    class Program
    {
        private static Dictionary<string, string> dict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            dict.Add("r", "Robin");
            dict.Add("c", "Christian");
            dict.Add("j", "Jonas");

            // würde im Fehlerfall eine Exception werfen
            //var robin = dict["r"];
            //Console.WriteLine(robin);

            // wirft keine Exception
            bool exists = dict.TryGetValue("x", out string name);
            if (exists)
            {
                Console.WriteLine($"mein name: {name}");
            }
            else
            {
                Console.WriteLine("could not get my name");
            }

            Console.ReadKey();
        }
    }
}
