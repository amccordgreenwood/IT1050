using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            string fullName;
            int    age;
            bool   isCitizen;
            bool   canVote;
            int    heightFeet;
            double heightInches;
            double totalHeightCM;
            string isAnswer;

            isCitizen = true;
            canVote = true;

            System.Console.Write("What is your Super Hero First Name? :");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your Super Hero Middle Initial name?:");
            middleName = System.Console.ReadLine();

            System.Console.Write("What is your Super Hero Last Name?:");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Your super hero full name " + firstName + " " +  middleName + ". "+ lastName + " ");
            fullName = System.Console.ReadLine();
            
            System.Console.Write("What is your super hero height in feet?:");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many super hero inches are you beyond your height in feet?:");
            heightInches = Double.Parse(System.Console.ReadLine());

            totalHeightCM =  heightFeet * heightInches;
      
            System.Console.WriteLine("How old are you 18 or older in earth years?:");
            age = int.Parse(System.Console.ReadLine());
            if (age >= 18  )
            System.Console.WriteLine("You can vote");

            else if (age >=17)
             System.Console.WriteLine("You cannot vote");
           
            System.Console.WriteLine("Are you a citizen of world? (yes/no)");
            isAnswer = System.Console.ReadLine();
            
            if (isAnswer =="yes")
            System.Console.WriteLine("You can vote");

            if (isAnswer == "no")
            System.Console.WriteLine("You cannot vote therefore leave this planet!");

            System.Console.WriteLine("Voting Details For " + firstName + " " + middleName + ". " + lastName + " ");
            System.Console.WriteLine("Your Total height Count in CM= " + totalHeightCM + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();




        }
    }
}
