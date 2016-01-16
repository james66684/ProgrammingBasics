using System;
class Problem6QuadraticEquation
{
    static void Main(string[] args)
        {
            Console.WriteLine("Enter values of a, b and c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                if (D > 0 && a != 0)
                {
                    Console.WriteLine("The Equasion got two real roots: x1={0}; x2={1}", (-b + D) / (2.0 * a), (-b - D) / (2.0 * a));
                }
                else if (D == 0 && a != 0)
                {
                    Console.WriteLine("The Equasion got one real root: x1=x2={0}", -b / (2.0 * a));
                }
                else
                {
                    Console.WriteLine("The Equasion has not real root");
                }
        }
}
