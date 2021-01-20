using System;
using System.Collections;

namespace GenericConstraintsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gc = new GenericClass<bool>(true);
            //gc.Print();

            //var gc2 = new GenericClass<MyStruct>(new MyStruct() { Name = "Robin" });
            //gc2.Print();

            Console.ReadKey();
        }
    }

    // generic constraint
    // T muss ein primitiver non-nullable Typ sein, also
    // z.B. int, float, bool, struct, aber nicht string
    class GenericClass<T> where T : struct 
    {
        private T content;

        public GenericClass(T cont)
        {
            this.content = cont;
        }

        public void Print()
        {
            Console.WriteLine($"Output: {this.content}");
        }
    }

    public struct MyStruct
    {
        public string Name { get; set; }
    }
}
