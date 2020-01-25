using System;

namespace EnterpriseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            char gender;
            double salary;
            bool isEmployed;

            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter your Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you employed (true or false)");
            isEmployed = bool.Parse(Console.ReadLine());
        }
    }
}
