using System;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new Hashtable();

            hs.Add(1, "Eins");
            hs.Add(2, "Zwei");
            hs.Add(3, "Drei");

            foreach (DictionaryEntry entry in hs)
            {
                Console.WriteLine($"Entry with key {entry.Key} has value {entry.Value}");
            }

            Console.ReadLine();
        }
    }
}
