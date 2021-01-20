using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedList gibts generisch und non-generisch
            SortedList l = new SortedList();
            
            l.Add("Tobi", 50);
            l.Add("Robin", 120);
            l.Add("Henry", 70);
            l.Add("Marco", 2);
            l.Add("Polo", 1337);
            l.Add("Derek", 100);

            // alternative:
            //SortedList<string, int> l2 = new SortedList<string, int>();


            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("Mitarbeiter {0} hat einen IQ von {1}.", l.GetKey(i), l.GetByIndex(i));
            }

            // checking if the sorted list has a fixed size or no
            Console.WriteLine(l.IsFixedSize);
            //checking if the sorted list is read only or not
            Console.WriteLine(l.IsReadOnly);

            Console.ReadLine();
        }
    }
}
