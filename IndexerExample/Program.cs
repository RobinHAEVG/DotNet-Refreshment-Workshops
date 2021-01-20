using System;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new IndexerClass();

            Console.WriteLine($"First Entry: {names[0]}");


            Console.ReadLine();
        }

    }

    class IndexerClass
    {
        public string[] Names { get; set; } = new string[10];

        public IndexerClass()
        {
            this.Names[0] = "Robin Kaiser";
            this.Names[1] = "Matthias Bruno Fröhlingsdorf";
            this.Names[2] = "Michael Kaiser";
            this.Names[3] = "Birgit Emonts-Kaiser";
            this.Names[4] = "Nicolas Kaiser";
            this.Names[5] = "Robert Hetzenegger";
            this.Names[6] = "Robert Müller";
            this.Names[7] = "Hanz Heizer";
            this.Names[8] = "Timmy Neutron";
            this.Names[9] = "Billy Bob";
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
