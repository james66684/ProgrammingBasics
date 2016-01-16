using System;

    class Problem10EmployeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write employee's first name:");
                string firstName = Console.ReadLine();
            Console.WriteLine("Write employee's last name:");
                string lastName = Console.ReadLine();
            Console.WriteLine("Write employee's age:");
                int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's gender:");
                char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's ID number:");
                int idNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's unique number:");
                int empoyeeNumber = int.Parse(Console.ReadLine());
               
            Console.WriteLine("First Name : {0}", firstName);
            Console.WriteLine("Last Name : {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", idNumber);
            Console.WriteLine("Unique Employee number: {0}", empoyeeNumber);
        }
    }
