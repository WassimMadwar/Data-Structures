using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>()
            {
                {"apple", 10},
                {"banana", 20},
                {"Banana", 20},
                {"orange", 15}
            };
            Console.WriteLine("Contents of the SortedDictionary:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            // Accessing values by key
            Console.WriteLine("\nAccessing values by key:");
            Console.WriteLine($"Value of 'apple': {sortedDict["apple"]}");
            Console.WriteLine($"Value of 'orange': {sortedDict["orange"]}");


            // Checking if a key exists
            Console.WriteLine("\nChecking if a key exists:");
            Console.WriteLine($"Contains 'banana': {sortedDict.ContainsKey("banana")}");
            Console.WriteLine($"Contains 'grape': {sortedDict.ContainsKey("grape")}");


            // Removing an element
            sortedDict.Remove("banana");
            Console.WriteLine("\nContents of the SortedDictionary after removal:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
