using System;

    class Problem10EmployeeData
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Write client first name:");
            string firstName = Console.ReadLine();
        Console.WriteLine("Write client middle name:");
            string middleName = Console.ReadLine();
        Console.WriteLine("Write client last name:");
            string lastName = Console.ReadLine();
        Console.WriteLine("Client's Money Ballance:");
            decimal moneyBallance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Bank Name:");
            string bankName = Console.ReadLine();
        Console.WriteLine("IBAN:");
            object iban = Console.ReadLine();
        Console.WriteLine("Client's credit card numbers:");
            long creditCardNumberOne = long.Parse(Console.ReadLine());
            long creditCardNumberTwo = long.Parse(Console.ReadLine());
            long creditCardNumberTree = long.Parse(Console.ReadLine());
        Console.WriteLine("First Name : {0}", firstName);
        Console.WriteLine("Middle name : {0}", middleName);
        Console.WriteLine("Last Name : {0}", lastName);
        Console.WriteLine("Money Ballance: {0}", moneyBallance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Client's credit card numbers: {0}\n{1}\n{2}", creditCardNumberOne, creditCardNumberTwo, creditCardNumberTree);
        }
    }
