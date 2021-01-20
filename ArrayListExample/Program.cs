using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // add one by one
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Robin");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // or use initializer syntax
            ArrayList arlist2 = new ArrayList
            {
                879,
                "Toby",
                false,
                13.37,
                null
            };

            // Use the AddRange(ICollection c) method to add all elements from an Array,
            // HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.

            // explizit
            int elem1 = (int)arlist1[0]; // returns 1
            string elem2 = (string)arlist2[1]; // returns "Tobi"

            // implizit
            var elem3 = arlist1[2]; // returns true
            var elem4 = arlist2[4]; // returns null

            Console.WriteLine($"elem1: {elem1}, type: {elem1.GetType()}");
            Console.WriteLine($"elem2: {elem2}, type: {elem2?.GetType()}");
            Console.WriteLine($"elem3: {elem3}, type: {elem3?.GetType()}");
            Console.WriteLine($"elem4: {elem4}, type: {elem4?.GetType()}");

            Console.ReadLine();
        }
    }
}
