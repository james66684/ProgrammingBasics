using System;
    class Problem11BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of the {0} is:\n{1}"
                                , number, Convert.ToString(number, 2).PadLeft(16, '0'));
            int position = 3;
            int bitChecker = 1 << position;

            Console.WriteLine((number & bitChecker) == bitChecker ? "The third bit is: 1 " : "The third bit is: 0");
        }
    }
