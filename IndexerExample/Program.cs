using System;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerClass names = new IndexerClass();

            Console.WriteLine($"First Entry: {names[0]}");
            Console.WriteLine($"Second Entry: {names[1]}");

            Console.ReadKey();
        }
    }

    class IndexerClass
    {
        public string[] Names { get; set; } = new string[10];

        public IndexerClass()
        {
            this.Names[0] = "Timothy";
            this.Names[1] = "Morgan Freeman";
            this.Names[2] = "Michael DeGhee";
            this.Names[3] = "Hugh Grant";
            this.Names[4] = "Jason M.";
        }

        public string this[int index]
        {
            get => (index >= 0 && index < this.Names.Length) ? this.Names[index] : "";
            set
            {
                if (index >= 0 && index < this.Names.Length)
                {
                    this.Names[index] = value;
                }
            }
        }
    }
}
