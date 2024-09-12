using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArr[1] = new int[] { 0, 2, 4 };
            jaggedArr[2] = new int[] { 11, 22 };


            // Display the array elements
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

                Console.WriteLine("--------------------------------- LINQ Operations -------------------------------");
            int[][] jaggedArray = {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 ,55},
                new int[] { 7, 8, 9, 10,22 }
            };


            // Flatten the jagged array and sum all elements
            int totalSum = jaggedArray.SelectMany(subArray => subArray).Sum();
            Console.WriteLine("Total Sum: " + totalSum);


            // Find the maximum element in the jagged array
            int maxElement = jaggedArray.SelectMany(subArray => subArray).Max();
            Console.WriteLine("Maximum Element: " + maxElement);


            // Filter arrays having more than 3 elements and select their first element
            var firstElements = jaggedArray.Where(subArray => subArray.Length > 3)
                                           .Select(subArray => subArray.First());
            Console.Write("First Elements of Long Rows: ");
            foreach (var element in firstElements)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
