using System;

    class Problem5FormattingNumbers
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Write first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Write second number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Write third number:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
