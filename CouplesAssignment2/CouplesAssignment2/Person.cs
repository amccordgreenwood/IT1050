using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplesAssignment2
{
    class Person

    {
        public Person Spouse;
        public string Name;
        public string FirstName;
        public string LastName;
        public int Age;
        public string MaritalStatus;
        public string SpouseFirstName;
        public string SpouseLastName;
        public int SpouseAge;
        public int sumOfAllAges;

        public string GetFullName(string firstName, string lastName)
        {
            string fullName = "";
            fullName += this.FirstName;
            fullName += ",";
            fullName += this.LastName;
            return fullName; 
        }

        public static void PrintNameAndAge(string firstName, string lastName, int age, string SpouseFirstName, string SpouseLastName)
            
        {
           //System.Console.WriteLine("Printing Results:  " + firstName + lastName + age + spouseFirstName + spouseLastName );
           System.Console.WriteLine(firstName + ", " + lastName + " (" + age + ")");
            
        }
        


    }
}
