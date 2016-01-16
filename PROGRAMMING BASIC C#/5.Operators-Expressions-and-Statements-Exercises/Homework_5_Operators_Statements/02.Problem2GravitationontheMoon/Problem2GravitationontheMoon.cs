using System;

    class Problem2GravitationontheMoon
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter weight of a man:");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("The weight of a man on the moon is {0}", weight*0.17);
        }
    }
