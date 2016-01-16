using System;
using System.Collections.Generic;

class Problem5SortingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            numbers.Sort();
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
