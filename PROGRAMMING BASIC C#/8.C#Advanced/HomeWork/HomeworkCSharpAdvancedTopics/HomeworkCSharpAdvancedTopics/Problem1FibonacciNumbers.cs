using System;
    class Problem1FibonacciNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Fibonacci number:");
            int n = int.Parse(Console.ReadLine());

            decimal nthMember = Fib(n);
            Console.WriteLine(nthMember);
            }

            private static decimal Fib(int n)
            {
            decimal firstNumber = 0m;
            decimal secondNumber = 1m;
            decimal sum;

            for (int i = 0; i < n; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }

        return secondNumber;
        }
    }
