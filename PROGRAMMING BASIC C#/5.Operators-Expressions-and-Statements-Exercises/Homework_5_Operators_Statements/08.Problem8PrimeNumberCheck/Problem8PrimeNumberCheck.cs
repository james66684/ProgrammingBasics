using System;

    class Problem8PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer number lesser or equal to 100");
            int number = int.Parse(Console.ReadLine());
            bool check = number >= 100;

                if (check)
                {
                    Console.WriteLine("Invalid number");
                }
                    else if ((number == 1 || number == 2 || number == 3 || number == 5 || number == 7)
                            ^ (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0))
                    {
                        Console.WriteLine("The number is Prime");
                    }
                else
                Console.WriteLine("The number is NOT Prime");
        }
    }