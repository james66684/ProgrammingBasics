using System;
    class Problem3CirclePerimeterandArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of the Circle:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = Math.PI*2*radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The perimeter of the Circle is:{0:F2}", perimeter);
            Console.WriteLine("The area of the circle is {0:F2}", area);
       }
    }
