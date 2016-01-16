using System;

    class Problem7QuotesinStrings
    {
        static void Main(string[] args)
        {
        string textOne = "The \"use\" of quotations causes difficulties.";
        string textTwo = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}", textOne, textTwo);
        }
    }
