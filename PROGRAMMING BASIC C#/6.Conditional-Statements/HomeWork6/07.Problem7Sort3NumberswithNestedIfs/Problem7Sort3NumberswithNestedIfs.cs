﻿using System;
    class Problem7Sort3NumberswithNestedIfs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
                if (a > b && b < c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                    else if (a < c)
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                }
                else if (a < b && a < c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                    else if (b < c)
                    {
                        Console.WriteLine("{0} {1} {2}", c, b, a);
                    }
                }
                else if (a == b)
                {
                    if (c > b)
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                    else if (c == b)
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
            }
        }
    }