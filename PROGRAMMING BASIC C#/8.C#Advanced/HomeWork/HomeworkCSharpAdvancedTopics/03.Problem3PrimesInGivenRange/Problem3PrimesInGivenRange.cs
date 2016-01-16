using System;
using System.Collections.Generic;

class Problem3PrimesInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Enter first number in the range:");
            Console.WriteLine("Enter last number in the range:");
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var foundPrimes = FindPrimesInRange(startNum, endNum);
            printPrimes(foundPrimes);
        }
        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();
            if (start < 2)
            {
                start = 2;
            }
            for (int i = start; i <= end; i++)
            {
                if (isNumberPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
        static bool isNumberPrime(int number)
        {
            bool isPrime = true;
            int square = (int)Math.Sqrt(number);
            for (int i = 2; i <= square; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static void printPrimes(List<int> primeNumbers)
        {
            string result = string.Join(", ", primeNumbers);
            Console.WriteLine(result);
        }
    }
