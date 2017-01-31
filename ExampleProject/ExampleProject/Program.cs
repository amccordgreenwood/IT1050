namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
//DACLARING VARIABLES SECTION ONE
            //declare a value you want to store some information and you not sure what the value is going to be the value might change.\
            // c# is a strongly type lanuge

          //[type] [variable-name] [semi-colon]
            string name;  // create a space in memory; there are three tokens here; blue known word in c# key word (keyword)
            string userName;
            int age;
            int userID;
            bool isGood;
            double weight;
            float teamBattingAverage;
            long someReallyHugeInteger;
            double someReallylongDecimal;
            bool isDoorClosed;

//ASSIGNING VALUES SECTION 1

          //[type] [variable-name][semi-colon] 
            string teamName;
          //[varible-name][assignment operator] [variable]
            teamName = "Cleveland Indians"; // CORRECT string name assignment 

            int numberOfPlayersOnTeam;
            numberOfPlayersOnTeam = 40;

            long somehugeInteger;
            somehugeInteger = 100000000;

            float teamBattingAverages;
            teamBattingAverages = .333f;

            double teamSluggingAverage;
            teamSluggingAverage = 666;

            bool isDoorClose;
            isDoorClose = true;
            isDoorClose = false;

            //COMBINE THE VARIABLE DECLARATION AND VALUE ASSIGNMENT = COMPOUND STATEMENT
                   
            string myName = "Armelia";
            int myWeigt = 150;

        }

    }
}
