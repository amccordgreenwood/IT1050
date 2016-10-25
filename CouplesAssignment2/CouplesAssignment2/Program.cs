namespace CouplesAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Armelia";
            person1.LastName = "McCord";
            person1.Age = 19;
            person1.MaritalStatus = "Y";
            person1.Spouse = new Person();
            person1.Spouse.FirstName = "Armelia's Husband";
            person1.Spouse.LastName = person1.LastName;
            person1.Age = 19;
            //
            Person person2 = new Person();
            person2.FirstName = "Sue";
            person2.LastName = "Rowe";
            person2.Age = 65;
            person2.MaritalStatus = "Y";
            person2.Spouse = new Person();
            person2.Spouse.FirstName = "Jimmy";
            person2.Spouse.LastName = person1.LastName;
            person2.Age = 69;
            person2.Spouse.Spouse = person2;



            person1.PrintNameAndAge();
            person1.Spouse.PrintNameAndAge();

            System.Console.WriteLine("[ Enter information for p1 ]");

            System.Console.WriteLine("What is your first name: " + person1.FirstName);
            person1.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: " + person1.LastName) ;
            person1.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: "+ person1.Age);
            person1.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: " + person1.MaritalStatus);
            person1.MaritalStatus = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's first name: ");
            person1.Spouse.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's age: ");
            person1.Spouse.Age = int.Parse(System.Console.ReadLine());

            //
            System.Console.WriteLine("[ Enter information for p2 ]");
                        
            System.Console.WriteLine("What is your first name: " + person2.FirstName);
            person1.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name: " + person2.LastName);
            person1.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your age: " + person1.Age);
            person1.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your martial status: " + person2.MaritalStatus);
            person1.MaritalStatus = System.Console.ReadLine();

            System.Console.WriteLine("What is your spouse's first name: ");
            person1.Spouse.FirstName = System.Console.ReadLine();
            
            System.Console.WriteLine("What is your spouse's age: ");
            person1.Spouse.Age = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine(person1.GetFullName(person1.FirstName , person1.LastName));
            System.Console.WriteLine(person1.Spouse.GetFullName(person1.Spouse.FirstName, person1.LastName));
            System.Console.WriteLine(person2.GetFullName(person2.FirstName, person2.LastName));
            System.Console.WriteLine(person2.Spouse.GetFullName(person2.Spouse.FirstName, person2.LastName));

            int sumOfAllAges = person1.Age + person2.Age + person1.Spouse.Age + person2.Spouse.Age;
            int averageAge = sumOfAllAges / 4;
            System.Console.WriteLine("Average Age = " + averageAge); 

            System.Console.WriteLine("Printing Results:  ");
            Person.PrintNameAndAge(person1.FirstName, person1.LastName, person1.Age, person1.FirstName, person1.LastName);
            Person.PrintNameAndAge(person2.FirstName, person2.LastName, person2.Age, person2.FirstName, person2.LastName);

            System.Console.WriteLine("press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
