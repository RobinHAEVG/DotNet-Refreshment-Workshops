using System;
using System.Collections.Generic;

namespace QueueOfTExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-5.0
            // Represents a first-in, first-out collection of objects.

            Queue<string> names = new Queue<string>();
            names.Enqueue("Robin");
            names.Enqueue("Tobi");
            names.Enqueue("Daniel");
            names.Enqueue("Leo");
            names.Enqueue("Kirill");
            names.Enqueue("Hildegard");
            names.Enqueue("Enrico");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"\nPeek first name: {names.Peek()}");
            Console.WriteLine($"Dequeue first name: {names.Dequeue()}");
            Console.WriteLine($"Dequeue second name: {names.Dequeue()}");

            // kann aus IEnumerable neu erstellt werden
            Queue<string> names2 = new Queue<string>(names.ToArray());

            Console.WriteLine("\nInhalt der ersten Queue:");
            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
