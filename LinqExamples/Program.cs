using System;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForEach();
            Aggregate();
            All();

            Console.WriteLine("\ndone.");
            Console.ReadKey();
        }

        private static void All()
        {
            int[] intArray = { 11, 22, 33, 44, 55 };
            bool result = intArray.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + result);
        }

        private static void Aggregate()
        {
            string[] skills = { "C#", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = skills.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(result);
        }

        private static void ForEach()
        {
            var people = Enumerable.Range(0, 10).Select(e => Person.CreateRandom()).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"Vorname: {person.Firstname}");
            }

            Console.WriteLine("\n--------\n");

            people.ForEach(p => p.Firstname = p.Firstname.ToUpper());

            foreach (Person person in people)
            {
                Console.WriteLine($"Vorname: {person.Firstname}");
            }
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

            string[] firstnames = { "Robin", "Nick", "Tim", "Tom", "Robert", "Yu", "Stefanie", "Erica" };
            string[] lastnames = { "Müller", "Holland", "Redneck", "Wasabi", "Schneider", "Quitter", "Enjoy" };

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
