namespace Assignment_2_Person
{
    public class Person
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public string MaritalStatus;
        public string SpouseLastName;

        public string SpouseFirstName;
        public int SpouseAge;

        public static void GetFullName(string firstName,string lastName)
        {
         System.Console.WriteLine(lastName + ", " + firstName);
        }

        public static void PrintNameAndAge(string firstName, string lastName, int age, string SpouseFirstName, string SpouseLastName, int SpouseAge)
        {

         System.Console.WriteLine();
            System.Console.WriteLine(firstName + ", " + lastName + " (" + age + ")", SpouseFirstName + ", " + SpouseLastName + " (" + age + ")");
           


        
        }




    }
}
