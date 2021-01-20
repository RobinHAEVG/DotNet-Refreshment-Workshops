using System;

namespace PartialClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var b = new Book(1, "Robin Kaiser", "Productive PHP");
            b.PrintData();
            b.Publish();
            b.PrintData();

            Console.ReadLine();
        }
    }

    public partial class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public bool Published { get; set; }
    }

    public partial class Book
    {
        public Book(int id, string author, string title)
        {
            this.Id = id;
            this.Author = author;
            this.Title = title;
        }

        public void Publish()
        {
            this.Published = true;
        }

        public void PrintData()
        {
            Console.Write($"Book {this.Title} from author {this.Author} has ID {this.Id}");
            if (this.Published)
            {
                Console.Write(" and has been published.");
            }

            Console.WriteLine();
        }
    }
}
