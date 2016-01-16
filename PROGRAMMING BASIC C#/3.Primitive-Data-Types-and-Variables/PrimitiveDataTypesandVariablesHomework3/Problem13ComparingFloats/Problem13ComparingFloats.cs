using System;

class Problem13ComparingFloats
{
    static void Main(string[] args)
    {
        decimal a = 5.00000001m;
        decimal b = 5.00000003m;
        decimal margin = Math.Abs(a - b);
        margin = Math.Round(margin, 8);

        if (margin < 0.000001m)
        {
            Console.WriteLine("true");
            Console.WriteLine("The difference {0} < eps", margin);
        }

        if (margin == 0.000001m)
        {
            Console.WriteLine("false");
            Console.WriteLine("Border case. The difference {0} == eps.\nWe consider the numbers are different.", margin);
        }
        if (margin > 0.000001m)
        {
            Console.WriteLine("false");
            Console.WriteLine("The difference of {0} is too big (> eps)", margin);
        }
    }
}