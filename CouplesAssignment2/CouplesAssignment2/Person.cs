namespace CouplesAssignment2
{
    class Person
    {
        #region Member Variables
        public Person Spouse;               // Every Person has a Spouse.
        public string FirstName;            // Every Person has a FirstName.
        public string LastName;             // Every Person has a LastName.
        public int Age;                     // Every Person has an Age.
        public string MaritalStatus;          // Every Person is married.
        #endregion

        #region Static Variables
        public static double sumOfAllAges;     // There is ONE sum of all People ages.
        #endregion

        public string GetFullName()
        {
            return FirstName + " , " + LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + ", " + Age + ".");
        }
    }
}