using System;

    class Problem1OddorEvenIntegers
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter number:");
        int num = int.Parse(Console.ReadLine());
        bool result = num % 2 != 0;
        Console.WriteLine("The number is odd: {0}", result);
        }
    }

