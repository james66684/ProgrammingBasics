using System;

    class Problem4Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of rectangle is: {0}", (2*height+2*width));
            Console.WriteLine("The area of rectangle is: {0}", (height* width));
        }
    }

