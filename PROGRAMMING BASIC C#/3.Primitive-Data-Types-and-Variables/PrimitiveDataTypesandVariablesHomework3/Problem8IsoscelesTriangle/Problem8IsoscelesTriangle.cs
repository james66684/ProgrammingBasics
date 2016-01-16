using System;

    class Problem8IsoscelesTriangle
    {
        static void Main(string[] args)
        {
        char copyWriteSymbol = '\u00A9';
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", 
            "    "+copyWriteSymbol,
            "  "+copyWriteSymbol+"   "+ copyWriteSymbol,
            " "+copyWriteSymbol+"     "+ copyWriteSymbol,
            copyWriteSymbol+"  " +copyWriteSymbol+"  " +copyWriteSymbol+ "  "+copyWriteSymbol);
        }
    }
