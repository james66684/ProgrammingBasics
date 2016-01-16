using System;

    class Problem2PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company Name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter company Phone number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter company Enter fax number:");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Enter company web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter Manager first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Manager last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Manager age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Manager phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address:{0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age:{2}, tel:{3})", firstName, lastName, age, phone);
        }
    }
