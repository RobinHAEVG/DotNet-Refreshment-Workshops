using System;

namespace ParametersExample
{
    class Program
    {
        // in: must not be modified
        // out: must be modified
        // ref: can be modified
        static void Main(string[] args)
        {
            // out
            GetValOut(out string outVar);
            Console.WriteLine(outVar);

            // in: this is the default parameter type and must not be
            // supplied when calling a method
            string inVar = GetValIn( 33);
            Console.WriteLine(inVar);

            // ref: does not have any effect on reference types,
            // but allows value types to be treated as reference types

            int refVal = 142;
            SetValRef(ref refVal);

            Console.ReadKey();
        }

        public static void GetValOut(out string greeting)
        {
            greeting = "Hey";
        }

        public static string GetValIn(in int num)
        {
            return $"{num}";
        }

        public static void SetValRef(ref int num)
        {
            num = 1556;
        }
    }
}
