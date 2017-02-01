

namespace Lab1Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your first name? ");
            string firstName;
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle inital? ");
            string middleInital;
            middleInital = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            string lastName;
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Print full name to screen: " + firstName + " " + middleInital + ". " + lastName + " ");

            System.Console.Write("What is your height in feet? ");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Your total height in inches: ");  
            double totalFeetInInches;
            totalFeetInInches = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Your total height in inches is:");
            double totalHeightIn = heightFeet * 12 + totalFeetInInches;
            System.Console.WriteLine(totalHeightIn);
            //totalHeightIn = double.(System.Console.ReadLine());

            System.Console.WriteLine("Your total height in Centimeters is: ");
            double totalHeightCM = totalHeightIn * 2.54;
            System.Console.WriteLine(totalHeightCM);

            System.Console.Write("What is your age? ");
            int age;
            age = int.Parse(System.Console.ReadLine());

            //System.Console.Write("Are you a US citizen? Yes/No ");
            //bool isCitizen;
            //isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote;
            canVote = age >= 18;



            System.Console.WriteLine("Your full name to is: " + firstName + " . " + middleInital + " " + lastName + " ");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.WriteLine("Your total height in centimeters:" + totalHeightCM);
            System.Console.WriteLine("Press any key to continue...");
            System.Console.WriteLine("Voter eligibility:" + canVote);
                      
            System.Console.ReadKey();

            
        }
    }
}
