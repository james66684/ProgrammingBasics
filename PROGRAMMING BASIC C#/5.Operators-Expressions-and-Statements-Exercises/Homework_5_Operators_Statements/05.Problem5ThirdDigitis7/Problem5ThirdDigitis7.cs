using System;
    class Problem5ThirdDigitis7
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter number:");
        double number = double.Parse(Console.ReadLine());
        double firstDigit = number % 10;
        double secondDigit = (number / 10) % 10;
        double thirdDigit = (number / 100) % 10;
        bool digit7 = thirdDigit == 7;
        Console.WriteLine(digit7);
        }
    }
