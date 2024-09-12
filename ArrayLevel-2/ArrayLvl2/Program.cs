using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLvl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original array
            int[] original = { 1, 2, 3, 4, 5 };


            // Array to hold the copy
            int[] copy = new int[7];


            // Copying array
            Array.Copy(original, copy, original.Length);


            // Displaying the copied array
            Console.WriteLine("Copied Array:");
            foreach (int element in copy)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();


            Console.WriteLine("------------------------------- Part 2 --------------------------");
            //LINQ (Language Integrated Query) with Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenSquares = numbers.Where(n => n % 2 == 0).Select(n => n * n);


            // Displaying results
            Console.WriteLine("Squares of even numbers:");
            foreach (var num in evenSquares)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

            Console.WriteLine("------------------------------- Part 3 --------------------------");

            var people = new[]
            {
                new { Name = "Alice", Age = 30 },
                new { Name = "Bob", Age = 25 },
                new { Name = "Charlie", Age = 35 },
                new { Name = "Diana", Age = 30 },
                new { Name = "Ethan", Age = 25 }
            };
            Console.WriteLine(" count is " + people.Count());
            // Grouping people by Age, then ordering within each group
            var groupedByAge = people.GroupBy(p => p.Age)
                                     .Select(group => new
                                     {
                                         Age = group.Key,
                                         People = group.OrderBy(p => p.Name)
                                     });

            foreach (var item in groupedByAge)
            {
                Console.WriteLine($"Age Group: {item.Age}");
                foreach (var person in item.People)
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }

            Console.ReadKey();
            Console.WriteLine("------------------------------- Part 4 --------------------------");

            // Array of numbers
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Filtering to get only even numbers
            var evenNumbers = numbers2.Where(n => n % 2 == 0);

            // Aggregating - calculating the sum of even numbers
            int sumOfEvenNumbers = evenNumbers.Sum();

            Console.WriteLine("Even Numbers :");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nSum of Even Numbers: {sumOfEvenNumbers}");
            Console.ReadKey();

            Console.WriteLine("------------------------------- Part 5 --------------------------");

            var employees = new[]
            {
                new { Id = 1, Name = "Alice", DepartmentId = 2 },
                new { Id = 2, Name = "Wassim", DepartmentId = 1 }
            };


            // Array of departments
            var departments = new[]
            {
            new { Id = 1, Name = "Human Resources" },
            new { Id = 2, Name = "Development" }
            };


            // Joining employees with departments and projecting the result
            var employeeDetails = employees.Join(departments,
                                                 e => e.DepartmentId,
                                                 d => d.Id,
                                                 (e, d) => new { e.Name, Department = d.Name });


            // Displaying the results
            foreach (var detail in employeeDetails)
            {
                Console.WriteLine($"Employee: {detail.Name}, Department: {detail.Department}");
            }
            Console.ReadKey();
            Console.ReadKey();


        }
    }
}
