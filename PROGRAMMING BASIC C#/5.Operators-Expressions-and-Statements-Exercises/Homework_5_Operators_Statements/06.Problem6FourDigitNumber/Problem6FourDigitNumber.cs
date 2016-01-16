using System;
    class Problem6FourDigitNumber
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter four digit number: ");
        int n = int.Parse(Console.ReadLine());
        int d = n % 10;
        int c = (n / 10) % 10;
        int b = (n / 10 / 10) % 10;
        int a = (n / 10 / 10 / 10) % 10;
        Console.WriteLine("Sum of digits: {0} ", (a + b + c + d));
        Console.WriteLine("Reversed: {0}{1}{2}{3} ", d, c, b, a);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3} ", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3} ", a, c, b, d);
        }
    }
