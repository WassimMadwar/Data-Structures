using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 10, 20, 30,60,20,22 };
        


            Console.WriteLine("Elements in ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Insert(3, 40);
            //list.Capacity = 4;
            if (list.Capacity >= 4)
            {
                Console.WriteLine("Test Capacity :)");
                Console.WriteLine("Test Capacity :)");
                
            }
            list.Add(55);
            list.Sort();

            list.Remove(20); // Removing an element
            Console.WriteLine("After removing an element 20 and Add 55 and Sort() :");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("---------------------Part 2 ------------------------------");

            list.RemoveAt(2);

            Console.WriteLine("After RemoveAt(2)=22    :");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int lon3 = list.LastIndexOf(30);
            Console.WriteLine(" LastIndexOf(30) is return the Index  : " + lon3);

            Console.WriteLine("\n---------------------Part 3 ------------------------------\n");
            int lon = list.Count;
            Console.WriteLine(" Count is  : " + lon);

            Console.WriteLine();

            int lon2 = list.BinarySearch(55);
            Console.WriteLine(" BinarySearch(55) is return the Index  : " + lon2);

            Console.WriteLine();

            list.Reverse();
            Console.WriteLine("After Reverse   :");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine("\n---------------------Part 4 ------------------------------\n");

            ArrayList arrayList = new ArrayList { 1, 7, 8, 9, 10, 2, 3, 4, 5, 6};


            //we use cast here to convert it to int first then we apply the filter.
            var evenNumbers = arrayList.Cast<int>().Where(num => num % 2 == 0);


            Console.WriteLine("All even numbers  convert it to int first then we apply the filter :");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

            Console.WriteLine("\n---------------------Part 5 ------------------------------\n");

            var minValue = arrayList.Cast<int>().Min();
            var maxValue = arrayList.Cast<int>().Max();
            var Sum = arrayList.Cast<int>().Sum();
            var Average = arrayList.Cast<int>().Average();
            var Count = arrayList.Cast<int>().Count();

            Console.WriteLine("\nArrayList Items: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }

            Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
            Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
            Console.WriteLine("Sum values in the ArrayList: " + Sum);
            Console.WriteLine("Average values in the ArrayList: " + Average);
            Console.WriteLine("Count Items in the ArrayList: " + Count);


            arrayList.Sort();
            Console.WriteLine("\nArrayList Items After Sorting: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }
            Console.ReadKey();

            Console.WriteLine("\n---------------------Part 6 ------------------------------\n");

            ArrayList arrayList2 = new ArrayList { 1, 2, 3, 2, 4, 2, 5, 2 , 2 };

            int targetNumber = 2;

            var count = arrayList2.Cast<int>().Count(num => num == targetNumber);

            Console.WriteLine($"Number of occurrences of {targetNumber} in the ArrayList: {count}");

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
