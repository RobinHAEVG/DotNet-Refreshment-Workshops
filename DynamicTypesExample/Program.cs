using System;

namespace DynamicTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = new MyCoolClass();

            MyDynamicVar.Greet();

            Console.ReadKey();
        }
    }

    public class MyCoolClass
    {
        public void Greet()
        {
            Console.WriteLine("Hello, guys!");
        }
    }
}
