using System;
using System.Collections.Generic;
using System.Linq;
using LinqIntro;
// using LinqIntro;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> nums = new List<int> 
            {
                1,2,3,4,7,93,110,230,450
            };
            // find for find in JS
            int foundNum = nums.Find(n => n == 93);

            // where for filter in js
            List<int> filteredNums = nums.Where(n => n < 100).ToList();

            List<int> orderedAndFiltered = nums
                .Where(n => n < 100)
                .OrderByDescending(n => n)
                .ToList();

            // Sum (no more reduce like in js)
            int sum = nums.Sum();

            int smallest = nums.Min();

            int biggest = nums.Max();

            List<int> doubled = nums.Select(nums => nums *2).ToList();

            List<string> stringedNums = nums.Select(n => {
                return n.ToString();
            }).ToList();


            //  Query LINQ Syntax
            List<int> cohortStudentCount = new List<int>()
            {
                25, 12, 28, 22, 11, 25, 27, 24, 19
            };
            Console.WriteLine($"Largest cohort was {cohortStudentCount.Max()}");
            Console.WriteLine($"Smallest cohort was {cohortStudentCount.Min()}");
            Console.WriteLine($"Total students is {cohortStudentCount.Sum()}");

            IEnumerable<int> CohortSize = from count in cohortStudentCount
                where count < 25 && count > 11
                orderby count descending
                select count;

            IEnumerable<int> idealSizes = from count in cohortStudentCount
                where count < 27 && count > 19
                orderby count ascending
                select count;

            foreach (int c in CohortSize)
            {
                Console.Write($"{c}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"A group of cohort sizes is {CohortSize.Average()}");
            Console.WriteLine($"Average ideal size is {idealSizes.Average()}");

            // The @ symbol lets you create multi-line strings in C#
            Console.WriteLine($@"
            There were {idealSizes.Count()} ideally sized cohorts
            There have been {cohortStudentCount.Count()} total cohorts");


            // with Method Syntax
            List<int> idealStringLambda = cohortStudentCount
            .Where( count => count < 27 && count > 19 )
            .OrderBy(count => count)
            .ToList();

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
            foreach (string f in LFruits)
            {
            Console.WriteLine(f);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where();
            


        }
    }
}
