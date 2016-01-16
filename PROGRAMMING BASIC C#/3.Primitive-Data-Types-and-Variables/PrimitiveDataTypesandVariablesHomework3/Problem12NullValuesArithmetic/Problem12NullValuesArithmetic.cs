using System;

    class Problem12NullValuesArithmetic
    {
        static void Main(string[] args)
        {
        int? numberOne = null;
        double? numberTwo = null;
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);
        int? numberTree = null;
        numberOne = 33;
        numberTwo = numberTree;
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);
        }
    }