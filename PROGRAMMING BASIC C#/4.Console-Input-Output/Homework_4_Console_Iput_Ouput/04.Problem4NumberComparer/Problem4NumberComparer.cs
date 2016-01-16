using System;
    class Problem4NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Max(a, b);
            Console.WriteLine("The greater number is: {0}", result);
        }
    }
