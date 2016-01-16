using System;
    class Problem7PointinaCircle
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter points x and y: ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inside = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2);
        Console.WriteLine("Inside {0}", inside);
        }
    }