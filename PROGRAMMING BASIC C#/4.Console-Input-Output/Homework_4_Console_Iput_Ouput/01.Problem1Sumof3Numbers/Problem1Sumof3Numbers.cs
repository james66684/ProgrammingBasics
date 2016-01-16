using System;

    class Problem1Sumof3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (a + b + c));
        }
    }
