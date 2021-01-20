using System;
using System.Linq;
using System.Reflection;
// CURRENTLY NOT WORKING!
namespace GenericHardCopyExample
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var u = new Uri("https://www.codeforge.me/api/path?var=test");
            Console.WriteLine(u.ToString());

            Person ich = new Person() {Name = "Robin"};
            Console.WriteLine($"Ich: {ich.Name}");

            Person nichtDu = ich.HardCopy();
            Console.WriteLine($"Nicht Du: {nichtDu.Name}");

            Console.ReadKey();
        }
    }

    public static class Extensions
    {

        public static T HardCopy<T>(this T sourceObj) where T : class
        {
            T targetObj = Activator.CreateInstance<T>();
            PropertyInfo[] srcFields = targetObj.GetType().
                GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty);

            PropertyInfo[] destFields = sourceObj.GetType().
                GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);

            foreach (PropertyInfo property in srcFields)
            {
                PropertyInfo dest = destFields.FirstOrDefault(x => x.Name == property.Name);
                if (dest != null && dest.CanWrite)
                {
                    //Console.WriteLine($"prop found: {property.Name} with value {property.GetValue(targetObj)}");
                    dest.SetValue(sourceObj, property.GetValue(targetObj), null);
                }
            }

            return targetObj;
        }
    }
}
