using System;
using System.Collections.Generic;

namespace DictionaryWithTupleExample
{
    class Program
    {
        private static Dictionary<string, (string, int, int)> dict = new Dictionary<string, (string, int, int)>();
        static void Main(string[] args)
        {
            dict.Add("r", ("Robin", 31, 181));
            dict.Add("c", ("Christian", 26, 180));
            dict.Add("j", ("Jonas", 22, 183));

            var c = dict["c"];

            Console.WriteLine($"Dein Name: {c.Item1}. Du bist {c.Item2} Jahre alt und {c.Item3}cm groß.");

            Console.ReadKey();
        }
    }
}
