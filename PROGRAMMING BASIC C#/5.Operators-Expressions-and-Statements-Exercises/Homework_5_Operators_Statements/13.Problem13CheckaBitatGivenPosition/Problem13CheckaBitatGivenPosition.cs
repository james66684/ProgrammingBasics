using System;
    class Problem13CheckaBitatGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            bool checkBit = bit == 1;
            Console.WriteLine(checkBit);
        }
    }