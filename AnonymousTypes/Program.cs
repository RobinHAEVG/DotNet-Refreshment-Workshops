using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Basic usage. You could use a Tuple alternatively.
            // here, usage of the "var" keyword is a MUST
            var anon = new { MessageType = "Register", Allowed = false, Index = 3 };
            Console.WriteLine($"Message Type: {anon.MessageType}");
            Console.WriteLine($"Allowed: {anon.Allowed}");
            Console.WriteLine($"Index: {anon.Index}\n");

            // 2. advanced usage with LINQ
            List<Person> list = GetPeople();

            var subList = list.Select(
                person => new { Id = person.Id, Fullname = person.Firstname + " " + person.Lastname });

            foreach (var entry in subList)
            {
                Console.WriteLine($"Entry: {entry.Fullname} has the ID {entry.Id}");
            }

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }

        private static List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Firstname = "Barack O.",
                    Lastname = "Bama",
                    Age = 51,
                    Birthday = DateTime.Parse("1969-02-06 17:50:44"),
                },
                new Person()
                {
                    Id = 2,
                    Firstname = "Jamal",
                    Lastname = "Lorram",
                    Age = 21,
                    Birthday = DateTime.Parse("1999-02-06 14:05:41"),
                },
                new Person()
                {
                    Id = 3,
                    Firstname = "Fanny",
                    Lastname = "Pack",
                    Age = 45,
                    Birthday = DateTime.Parse("1984-11-24 08:34:44"),
                },
            };
        }

        public class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public DateTime Birthday { get; set; }
        }
    }
}
