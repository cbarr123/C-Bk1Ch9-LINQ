using System;
using System.Collections.Generic;
using System.Linq;
using LinqIntro;
// using LinqIntro;

namespace linq
{

    public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }


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

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }
            
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(names => names).ToList();
            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> AscNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> AscNum = AscNumbers.OrderBy(nu => nu).ToList();
            foreach(int nu in AscNum)
            {
                Console.WriteLine(nu);
            }
            Console.WriteLine();
            // Output how many numbers are in this list
            List<int> CountNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var TotalCountNumbers = CountNumbers.Count();
            Console.WriteLine(TotalCountNumbers);
            Console.WriteLine();
            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            var TotalPurchases = purchases.Sum();
            Console.WriteLine(TotalPurchases);
            Console.WriteLine();
            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            var MaxPrices = prices.Max();
            Console.WriteLine(MaxPrices);
            Console.WriteLine();
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            List<int> HeresSquaredo = wheresSquaredo.Where(SquareNumber => 
                
                Math.Sqrt(SquareNumber) % 1 == 0).ToList();
                

            {
                double sqrt = Math.Sqrt(num);
                return sqrt % 1 != 0;

        
            }
            //the join problem
            var reportItems = customers
                .Where(c => c.Balance >= 1000000)
                .Join(
                    banks,
                Customer => Customer.Bank,
                bank => bank.symbol,
                (Customer, bank) => 
                {
                    report new ReportItem
                    {CustomerName = Customer.Name,
                    BankName = bank.Name
                    };

                })


            var report = customers
            .Where(c => c.Balance >= 10000000)
            .GroupBy(c => c.Bank)
            Select





            foreach(int sq in HeresSquaredo)
            {
                Console.WriteLine(sq);
            }
            Console.WriteLine();

            // Build a collection of customers who are millionaires

            

            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };







        }
    }
}
