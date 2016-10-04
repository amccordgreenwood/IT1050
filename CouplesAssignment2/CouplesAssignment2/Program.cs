using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplesAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person spouse1 = new Person();
            Person spouse2 = new Person();

            spouse1.LastName = person1.LastName;
            spouse2.LastName = person2.LastName;


            System.Console.WriteLine("[ Enter information for p1 ]");

            System.Console.WriteLine("What is your first name: ");
            person1.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: ");
            person1.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: ");
            person1.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: ");
            person1.MaritalStatus = System.Console.ReadLine();
        
            System.Console.WriteLine("What is your spouse's first name: ");
            spouse1.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's age: ");
            spouse1.SpouseAge = int.Parse(System.Console.ReadLine());

            //
            System.Console.WriteLine("[ Enter information for p2 ]");

            System.Console.WriteLine("What is your first name: ");
            person2.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: ");
            person2.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: ");
            person2.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: ");
            person2.MaritalStatus = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's first name: ");
            spouse2.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's age: ");
            spouse2.SpouseAge = int.Parse(System.Console.ReadLine());


            
            System.Console.WriteLine(person1.GetFullName(person1.FirstName,person1.LastName));
            System.Console.WriteLine(spouse1.GetFullName(spouse1.FirstName, person1.LastName));
            System.Console.WriteLine(person2.GetFullName(person2.FirstName, person2.LastName));
            System.Console.WriteLine(spouse2.GetFullName(spouse2.FirstName, person2.LastName));

            int sumOfAllAges = person1.Age + person2.Age + spouse1.Age + spouse2.Age;
            int averageAge = sumOfAllAges / 4;
            System.Console.WriteLine("Average Age = " + averageAge);

            System.Console.WriteLine("Printing Results:  ");
            Person.PrintNameAndAge(person1.FirstName, person1.LastName, person1.Age, spouse1.FirstName, spouse1.LastName);
            Person.PrintNameAndAge(person2.FirstName, person2.LastName, person2.Age, spouse2.FirstName, spouse2.LastName);

            System.Console.WriteLine("press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
