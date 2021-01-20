using System;
using System.Linq.Expressions;

namespace NullableTypesExample
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1?view=net-5.0
            // public struct Nullable<T> where T : struct

            // Standardschreibweise
            Nullable<int> num1 = null;

            // Kurzschreibweise
            int? num2 = null;

            if (num2 == null)
            {
                num2 = 17;
            }

            int? done = null;
            int m = done.GetValueOrDefault(4);

            int? i = 5;
            int k = i ?? 3;

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");

            Console.ReadLine();
        }
    }
}
