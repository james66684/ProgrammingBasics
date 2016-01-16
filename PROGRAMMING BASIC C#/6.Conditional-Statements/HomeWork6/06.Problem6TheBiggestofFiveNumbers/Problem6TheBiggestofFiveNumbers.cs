using System;
    class Problem6TheBiggestofFiveNumbers
    {
        static void Main(string[] args)
        {
            double biggest = double.MinValue;
            double current;
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Enter the number {0}: ", i);
                    current = double.Parse(Console.ReadLine());
                    if (current > biggest)
                    {
                        biggest = current;
                    }
                }
            Console.WriteLine("The biggest number is: {0}", biggest);
        }
    }
