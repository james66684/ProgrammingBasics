using System;
    class Problem1Numbersfrom1toN
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter positive integer number:");
        int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
