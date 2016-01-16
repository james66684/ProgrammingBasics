using System;

    class Problem1ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("{0} {1}", b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1}", a, b);
                }
        }
    }