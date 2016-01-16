using System;
using System.Globalization;

class Problem4DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two dates in format dd.MM.yyyy:");
            string dateStringFirst = Console.ReadLine();
            string dateStringSecond = Console.ReadLine();
            string format = "d.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(dateStringFirst, format,
            System.Globalization.CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateStringSecond, format,
            CultureInfo.InvariantCulture);
            int difference = CalculateNumberDifferenceDates(firstDate, secondDate);
            Console.WriteLine("Days between: {0} ", difference);
        }
        private static int CalculateNumberDifferenceDates(DateTime firstDate, DateTime secondDate)
        {
            
            TimeSpan ts = secondDate - firstDate;
         
            int differenceInDays = ts.Days;
            return differenceInDays;
        }
    }
