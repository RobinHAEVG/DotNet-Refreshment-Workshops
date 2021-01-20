using System;

namespace ParametersExample
{
    class Program
    {
        public delegate void MyDel(out string s);

        static void Main(string[] args)
        {
            MyDel t = GetVal;

            t(out string g);
            Console.WriteLine(g);

            Console.ReadKey();
        }

        public static void GetVal(out string greeting)
        {
            greeting = "Hey";
        }
    }
}
