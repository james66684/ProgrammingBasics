using System;

    class Problem9ExchangeVariableValues
    {
        static void Main(string[] args)
        {
        int a = 5;
        int b = 10;
        Console.WriteLine("{0}\n{1}", "Before\n" + a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("{0}\n{1}","After\n"+ a, b);
        }   
    }
