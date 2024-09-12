using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

        // Adding elements
        fruitBasket.Add("Apple", 5);
        fruitBasket.Add("Banana", 2);
        //the following commented line will cause an error because they key is repeated.
        //fruitBasket.Add("Banana", 5);
        fruitBasket.Add("Orange", 12);

        // Accessing and updating elements
        fruitBasket["Apple"] = 10;

        Console.WriteLine("\nDictionary Content:");
        // Iterating through the dictionary
        foreach (KeyValuePair<string, int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Removing an element
        fruitBasket.Remove("Banana");

        Console.WriteLine("\nDictionary Content after removing Banana:");
        // Iterating through the dictionary after removing Banana
        foreach (KeyValuePair<string, int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        Console.ReadKey();

        Console.WriteLine("\n-------------------------------------------- part2 -------------------------------------------------");
        //TryGetValue Method in C# Dictionaries

        // Creating and initializing the dictionary
        Dictionary<string, int> fruitBasket2 = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 }
        };


        // Using TryGetValue
        if (fruitBasket2.TryGetValue("Apple", out int appleQuantity))
        {
            Console.WriteLine($"Apple quantity: {appleQuantity}");
        }
        else
        {
            Console.WriteLine("Apple not found in the basket.");
        }


        //the following line will make exception error because orange is not there.
        // Console.WriteLine($"Orange quantity: {fruitBasket["Orange"]}");


        // Using TryGetValue
        if (fruitBasket2.TryGetValue("Orange", out int OrangeQuantity))
        {
            Console.WriteLine($"Orange quantity: {OrangeQuantity}");
        }
        else
        {
            Console.WriteLine("Orange not found in the basket.");
        }

        Console.ReadKey();

        Console.WriteLine("\n-------------------------------------------- part3 -------------------------------------------------");
        //Utilizing LINQ with Dictionaries

        fruitBasket2.Add("Orange", 12);
        
        var fruitInfo = fruitBasket2.Select(kpv => new { kpv.Key, kpv.Value });

        // Using LINQ to transform items
        // Displaying the results
        Console.WriteLine("Transformed Items:");
        foreach (var item in fruitInfo)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to filter items
        var filteredFruit = fruitBasket2.Where(kpv => kpv.Value > 3);


        Console.WriteLine("\nFiltered Items >3:");
        foreach (var item in filteredFruit)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to sort by value
        var sortedByQuantity = fruitBasket2.OrderBy(kpv => kpv.Value);

        Console.WriteLine("\nSorted Items:");
        foreach (var item in sortedByQuantity)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        // Using LINQ to sort by value
        var sortedByQuantityDesc = fruitBasket2.OrderByDescending(kpv => kpv.Value);


        Console.WriteLine("\nSorted Items Desc:");
        foreach (var item in sortedByQuantityDesc)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }

        // Using LINQ to aggregate data
        int totalQuantity = fruitBasket2.Sum(kpv => kpv.Value);

        Console.WriteLine($"\nTotal Quantity: {totalQuantity}");
        

        int MaxF = fruitBasket2.Max(kpv => kpv.Value);
        Console.WriteLine($"\nMax  Quantity: {MaxF}");
        Console.WriteLine("Count: " + fruitBasket2.Count());
        fruitBasket2.FirstOrDefault();
        Console.WriteLine(" is Any Fruit = 3 : ======> " + fruitBasket2.Any(kpv => kpv.Value ==3));

        var target = fruitBasket2.Where(kpv => kpv.Key == "Orange");
        foreach (var item in target)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");

        }


        Console.ReadKey();

        Console.WriteLine("\n-------------------------------------------- part4 -------------------------------------------------");
        //Advanced LINQ Queries with Dictionaries
        // Dictionary for grouping
        Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
        {
            { "Apple", "Tree" },
            { "Banana", "Herb" },
            { "Cherry", "Tree" },
            { "Strawberry", "Bush" },
            { "Raspberry", "Bush" }
        };

        fruitsCategory.Add("koko", "Herb");
        // Grouping fruits by category

        Console.WriteLine("Category: Grouping fruits by category\n");
        var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
        foreach (var group in groupedFruits)
        {
            Console.WriteLine($"Category: {group.Key}");

            foreach (var fruit in group)
            {
                Console.WriteLine($" - {fruit.Key}");
            }
        }


        Console.ReadKey();
        Console.WriteLine("\n---------------------- Wassim ---------------------------\n");
        var SortSS = fruitsCategory
           .Where(kpv => kpv.Value == "Tree")
           .GroupBy(kpv => kpv.Value);
        foreach (var sort in SortSS)
        {
            Console.WriteLine($"Category: {sort.Key}");

            foreach (var fruit in sort)
            {
                Console.WriteLine($" - {fruit.Key}");
            }
        }

        Console.WriteLine("\n-------------------------------------------------\n");
        // Another Dictionary for combined queries
        Dictionary<string, int> fruitBasket3 = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


        // Combined LINQ queries
        var sortedFilteredFruits = fruitBasket3
            .Where(kpv => kpv.Value > 3)
            .OrderBy(kpv => kpv.Key)
            .Select(kpv => new { kpv.Key, kpv.Value });

        Console.WriteLine("\nSorted and Filtered Fruits:");
        foreach (var fruit in sortedFilteredFruits)
        {
            Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
        }

        Console.ReadKey();
    }
}
