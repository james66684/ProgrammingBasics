using System;

    class Problem2PrimeChecker
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            long n = long.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine(false);
                return;
            }
            Console.WriteLine("{0}", CheckPrimeNumber(n));
        }
        private static bool CheckPrimeNumber(long n)
        {
            int i = 0;
            bool checkPrime = false;
            for (i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (((i != 1 && i != n) && n % i == 0))
                {
                    checkPrime = false;
                    break;
                }
            }
            if (i > (int)Math.Sqrt(n))
            {
                checkPrime = true;
            }
            return checkPrime;
        }
    }