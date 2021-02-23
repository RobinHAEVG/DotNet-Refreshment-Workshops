using System;
using System.IO;

namespace ExceptionsExample
{
    class Program
    {
        public static bool IsEnabled { get; set; }
        static void Main(string[] args)
        {
            try
            {
                CallAllMethods();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Das passiert nach dem Abfangen.");
            Console.ReadKey();
        }

        private static void CallAllMethods()
        {
            IsEnabled = false;

            try
            {
                TryTheIndex();
                bool oldEnough = CheckAge(160);
                Console.WriteLine($"Old enough: {oldEnough}");
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine($"{nameof(InvalidAgeException)}: {e.Message}");
                throw;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(nameof(IndexOutOfRangeException) + ": " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                IsEnabled = true;
                Console.WriteLine("das wird immer ausgeführt");
            }
            
        }

        static void TryTheIndex()
        {
            int[] nums = new[] {1, 2, 3};
            Console.WriteLine(nums[10]);
        }

        static bool CheckAge(int age)
        {
            if (age >= 150 || age < 0)
            {
                throw new InvalidAgeException($"Supplied age {age} is invalid");
                //throw new UnauthorizedAccessException("nö");
            }
            else if (age >= 18)
            {
                return true;
            }
            
            return false;
        }
    }
}
