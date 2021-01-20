using System;
using System.Collections;
using System.Collections.Generic;

namespace StackOfTExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/de-de/dotnet/api/system.collections.generic.stack-1?view=net-5.0
            // LIFO (Last-In-First-Out)

            Stack<int> nums = new Stack<int>();
            nums.Push(3);
            nums.Push(0);
            nums.Push(5);
            nums.Push(3000);
            nums.Push(324);
            nums.Push(45);

            foreach (int num in nums)
            {
                Console.WriteLine($"Number in nums: {num}");
            }

            Console.WriteLine($"\nFirst peek: {nums.Peek()}");
            Console.WriteLine($"First pop: {nums.Pop()}");
            Console.WriteLine($"Second pop: {nums.Pop()}");

            // neuen Stack aus vorhandenem IEnumerable erzeugen
            Stack<int> num2 = new Stack<int>(nums);

            Console.ReadLine();
        }
    }
}
