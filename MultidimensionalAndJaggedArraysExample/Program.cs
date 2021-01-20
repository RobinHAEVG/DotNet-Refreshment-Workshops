using System;

namespace MultidimensionalAndJaggedArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2-dimensional arrays
            int[,] array2d = new int[,]
            {
                { 3, 1 }, 
                { 45, 4 }, 
                { 8, 1 }, 
                { 99, 3 }
            };
            Console.WriteLine($"2D: First, Second: {array2d[0, 1]}");

            // 3-dimensional arrays
            int[,,] array3d = new int[2,2,3] {
                {
                    { 1, 2, 3 }, 
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 }, 
                    { 10, 11, 12 }
                }
            };
            Console.WriteLine($"3D: Second, First, Third: {array3d[1, 0, 2]}");

            // jagged arrays

            // variante 1
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            // variante 2
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            Console.WriteLine($"Jagged 1: First, Second: {jaggedArray[0][1]}");
            Console.WriteLine($"Jagged 2: First, Fourth: {jaggedArray[0][3]}");

            Console.ReadLine();
        }
    }
}
