using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace LinqExamples
{
    class Program
    {
        private static int[] intArray = { 11, 22, 33, 44, 55 };
        private static int[] intArray2 = { 1, 2, 5, 4, 3 };
        private static int[] intArray3 = { 3, 3, 5, 3, 4 };
        private static int[] intArray4 = { 1, 2, 5 };
        private static int[] emptyIntArray = new int[0];
        private static string[] stringArray = { "C#", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
        private static List<Person> people = Enumerable.Range(0, 10).Select(e => Person.CreateRandom()).ToList();
        private static object[] scrambled = new object[] {"hallo", 123, 3.14, true};
        private static List<string> emptyStringList = new List<string>();

        static void Main(string[] args)
        {
            //ForEach();
            //Aggregate();
            //All();
            //Any();
            //CastAndOfType();
            //Concat();
            //Contains();
            //Count(); // +LongCount()
            //DefaultIfEmpty();
            //Distinct();
            //Empty();
            //Except();
            //First(); // +Last()
            //FirstOrDefault(); // +LastOrDefault()
            //GroupBy();
            //Intersect();
            //Join(); // ?
            //Max(); // +Min()!
            //OrderBy();
            //Ranges();
            //Repeat();
            //Reverse();
            //Select();
            //SelectMany();
            //SequenceEqual();
            //LinqSingle(); // Single is already in use
            //Skip();
            //SkipWhile();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        private static void SkipWhile()
        {
            //var result = 
        }

        private static void Skip()
        {
            // SkipLast()
            var result = people.Skip(8);
            //Console.WriteLine(result);
            foreach (Person p in result)
            {
                Console.WriteLine(p.Firstname);
            }
        }

        private static void LinqSingle()
        {
            try
            {
                //SingleOrDefault()
                var me = people.SingleOrDefault(e => e.Firstname == "Robin"); 
                Console.WriteLine($"Yes, that's me, and I'm {me.Age} years old.");
            }
            catch
            {
                Console.WriteLine($"Guess there is no Robin here...");
            }
        }

        private static void SequenceEqual()
        {
            // also works with reference types, e.g. List<T>
            var result = intArray2.SequenceEqual(intArray4);
            Console.WriteLine($"Sequence Equal: {result}");
        }

        private static void SelectMany()
        {
            // unklar
        }

        private static void Select()
        {
            Console.WriteLine("Initial values:");
            foreach (Person p in people)
            {
                Console.WriteLine($"\t{p.Firstname}\t{p.Lastname}\t{p.Age}");
            }

            var result = people.Select(e => e.Firstname);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            var result2 = people.Select(e => new { FirstN = e.Firstname, Age = e.Age });
            Console.WriteLine($"\nAfter select only first names:");
            foreach (var v in result2)
            {
                Console.WriteLine($"\t{v.FirstN}, {v.Age} years old");
            }
        }

        private static void Reverse()
        {
            Console.WriteLine($"Normal:");
            foreach (int i in intArray)
            {
                Console.WriteLine($"\t{i}");
            }

            var result = intArray.Reverse();
            Console.WriteLine($"\nReverse():");
            foreach (int i in result)
            {
                Console.WriteLine($"\t{i}");
            }
        }

        private static void Repeat()
        {
            IEnumerable<string> result = Enumerable.Repeat("hey", 3);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            var ppl = Enumerable.Repeat(Person.CreateRandom(), 100);
        }

        private static void Ranges()
        {
            var result1 = Enumerable.Range(0, 6);
            Console.WriteLine($"Enumerable.Range(0, 6):");
            foreach (int i in result1)
            {
                Console.WriteLine($"\t{i}");
            }

            //var result2 = intArray[1..4];
            //Console.WriteLine($"\nInteger Array Range 1..4");
            //foreach (int i in result2)
            //{
            //    Console.WriteLine($"\t{i}");
            //}
        }

        private static void OrderBy()
        {
            // OrderByDescending()!
            var result = people.OrderBy(e => e.Lastname);
            foreach (Person p in result)
            {
                Console.WriteLine($"First: {p.Firstname}\tLast: {p.Lastname}\t Age: {p.Age}");
            }
        }

        private static void Max()
        {
            // Min()
            var result1 = stringArray.Max();
            Console.WriteLine($"Result from intArray: {result1}");

            try
            {
                var result2 = emptyIntArray.Max();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
            }

        }

        private static void Join()
        {
            // unklar
            //var result = intArray2.Join(intArray3, i => i > 3, i => i >= 3);
        }

        private static void Intersect()
        {
            var result = intArray2.Intersect(intArray3);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        private static void GroupBy()
        {
            //var result = people.GroupBy(e => e.Firstname)
            //    .ToDictionary(group => group.Key, group => group.Count());

            //foreach (KeyValuePair<string, int> pair in result)
            //{
            //    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            //}


            var result2 = people.Select(p => new {FirstN = p.Firstname, LastN = p.Lastname}).GroupBy(g => g.FirstN);
            foreach (var grp in result2)
            {
                Console.WriteLine($"All people with first name {grp.Key}");
                foreach (var person in grp)
                {
                    Console.WriteLine($"\t{person.FirstN} {person.LastN}");
                }
            }
            //foreach (IGrouping<string, Person> grouping in result2)
            //{
            //    Console.WriteLine($"All people with first name {grouping.Key}");
            //    foreach (Person person in grouping)
            //    {
            //        Console.WriteLine($"\t{person.Firstname} {person.Lastname}");
            //    }
            //}
        }

        private static void FirstOrDefault()
        {
            var result = emptyStringList.FirstOrDefault();
            Console.WriteLine($"Result: {result}");
        }

        private static void First()
        {
            // Last()
            var result = people.First();
            Console.WriteLine(result.Firstname + " " + result.Lastname);
        }

        private static void Except()
        {
            IEnumerable<int> result = intArray2.Except(intArray3);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        private static void Empty()
        {
            var stringEnum = Enumerable.Empty<string>();
            IEnumerable<int> intEnum = Enumerable.Empty<int>();
        }

        private static void Distinct()
        {
            var result = intArray3.Distinct();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        private static void DefaultIfEmpty()
        {
            var result = stringArray.DefaultIfEmpty("hey");

            Console.WriteLine($"Count: {result.Count()}");
            Console.WriteLine($"Value: {result.ElementAt(0)}");
        }

        private static void Count()
        {
            var result = stringArray.Count(i => i.Length > 2);
            Console.WriteLine($"Elements: {result}");
        }

        private static void Contains()
        {
            var result = intArray2.Contains(3);
            Console.WriteLine(result ? "Yes" : "No");
        }

        private static void Concat()
        {
            var combinedArrays = intArray.Concat(intArray2);
            foreach (int i in combinedArrays)
            {
                Console.WriteLine(i);
            }
        }

        private static void CastAndOfType()
        {
            var allStringsFound = scrambled.OfType<string>();
            foreach (string s in allStringsFound)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--------\n");
            
            // throws exception
            try
            {
                var allCastToString = scrambled.Cast<string>();
                foreach (string s in allCastToString)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Any()
        {
            if (people.Any(p => p.Firstname == "Robin"))
                Console.WriteLine("Robin is there");
            else
                Console.WriteLine("Robin isn't there");
        }

        private static void All()
        {
            bool result = intArray.All(i => i > 10);
            Console.WriteLine("All: numbers are greater than 10 : " + result);
        }

        private static void Aggregate()
        {
            //var total = string.Join(", ", stringArray);

            // C#, MVC, WCF
            // 1. step: s1 = C#, s2 = MVC
            // 2. step: s1 = C#, MVC, s2 = WCF
            string result = stringArray.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(result);
        }

        private static void ForEach()
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"First name: {person.Firstname}");
            }

            Console.WriteLine("\n--------\n");

            people.ForEach(p => p.Firstname = p.Firstname.ToUpper());

            foreach (Person person in people)
            {
                Console.WriteLine($"First name: {person.Firstname}");
            }

            //people.ForEach(p => Console.WriteLine(p.Firstname.ToUpper()));
        }
    }

    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsMarried { get; set; }

        public static Person CreateRandom()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            string[] firstnames = { "Robin", "Nick", "Tim", "Tom", "Robert", "Yu", "Stefanie", "Erica", "Spaghetti" };
            string[] lastnames = { "Müller", "Holland", "Redneck", "Wasabi", "Schneider", "Quitter", "Enjoy", "Bolognese" };

            return new Person()
            {
                Firstname = firstnames.OrderBy(e => rnd.Next()).First(),
                Lastname = lastnames.OrderBy(e => rnd.Next()).First(),
                Age = rnd.Next(15, 75),
                BirthDay = new DateTime(rnd.Next(1970, 2000), rnd.Next(1, 13), rnd.Next(1, 29)),
                IsMarried = rnd.Next(0, 2) == 0,
            };
        }
    }
}
