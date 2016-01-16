using System;
    class Problem4MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three integers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
                if (a > 0 && b > 0 && c > 0 || a < 0 && b < 0 && c > 0 || a > 0 && b < 0 && c < 0 ||
                    a < 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("+");
                }
                else if (a < 0 && b > 0 && c > 0 || a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0 ||
                    a < 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine(0);
                }
        }
    }