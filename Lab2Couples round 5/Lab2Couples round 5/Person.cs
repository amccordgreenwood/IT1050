﻿namespace Lab2Couples_round_5
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;


        public void GatherDataFromUser()
        {


            this.FirstName = Person.AskForString("Enter Your First Name:");
            this.LastName = Person.AskForString("Enter Your Last Name:");
            this.Age = Person.AskForInteger("Enter Your Age");
        }

        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        public string GetFullName()
        {
            string FullName = this.FirstName = this.LastName;

            return FullName;

        }

        public static double sumOfAllAges;

        public static bool AskForBool(string prompt)
        {
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }
}
