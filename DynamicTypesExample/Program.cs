using System;
using Newtonsoft.Json;

namespace DynamicTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // example 1
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

            // example 2
            string json = "{\"name\": \"Robin\", \"age\": 31}";
            dynamic result = JsonConvert.DeserializeObject<dynamic>(json);
            Console.WriteLine($"\nUser {result.name} is {result.age} years old.");

            Console.WriteLine("press any key to quit");
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
