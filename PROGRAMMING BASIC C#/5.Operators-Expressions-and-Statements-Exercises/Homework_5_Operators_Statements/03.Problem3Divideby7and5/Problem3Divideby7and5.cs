using System;

    class Problem3Divideby7and5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            double num = double.Parse(Console.ReadLine());
            bool num5 = (num % 5) == 0;
            bool num7 = (num % 7) == 0;
                Console.WriteLine("Divided by 7 and 5? {0}", num7 && num5);
        }
    }
