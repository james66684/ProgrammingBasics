﻿using System;
    class Problem9PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please enter a int:");
                int intNum = int.Parse(Console.ReadLine());
                intNum = intNum + 1;
                Console.WriteLine(intNum);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter a double:");
                double doubleNum = double.Parse(Console.ReadLine());
                doubleNum = doubleNum + 1;
                Console.WriteLine(doubleNum);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                str += "*";
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
