using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem3Min_MaxSumAverageoNNumbers
{
    class Problem3MinMaxSumAverageoNNumbers 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers:");
            string input = Console.ReadLine();
            int n = Int32.Parse(input);
            int max = 0;
            int min = 1;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number:");
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if ((num <= 0) && (num <= min))
                {
                    min = num;
                    continue;
                }
                if (num <= min)
                {
                    min = num;

                }
                else if (num >= max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Avg = {0:F2}", (sum / n));
        }
    }
}
