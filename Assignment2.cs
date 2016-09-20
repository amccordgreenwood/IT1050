using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            
            System.Console.WriteLine("[ Enter information for p1 ]");

            System.Console.WriteLine("What is your first name: ");
            p1.FirstName =System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: ");
            p1.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: ");
            p1.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: ");
            p1.MaritalStatus = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's first name: ");
            p1.SpouseFirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's age: ");
            p1.SpouseAge = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine(" Enter information for p2");

            System.Console.WriteLine("What is your first name: ");
            p2.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: ");
            p2.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: ");
            p2.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: ");
            p2.MaritalStatus = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's first name: ");
            p2.SpouseFirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's age: ");
            p2.SpouseAge = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Printing Results");
            Person.PrintNameAndAge(p1.FirstName, p1.LastName, p1.Age, p1.SpouseFirstName, p1.SpouseLastName, p1.SpouseAge);
            Person.PrintNameAndAge(p2.FirstName, p2.LastName, p2.Age, p2.SpouseFirstName, p2.SpouseLastName, p2.SpouseAge);

            int sumOfAllAges = p1.Age + p1.SpouseAge + p2.Age + p2.SpouseAge;
            int averageAge = sumOfAllAges / 4;
            System.Console.WriteLine("Average Age = " + averageAge);

            System.Console.WriteLine("Press any key to continue...");
            System.Console.Read();
        }
   
   
    }
}
