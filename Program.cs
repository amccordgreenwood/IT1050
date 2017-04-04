

namespace Lab4Movies2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMovieMenu();
            CollectMovieTime();

            string command1 = System.Console.ReadLine();


            if (command1 == "1")
            {
                Price myPrice = new Price();
                myPrice.GatherMatineePrice();
                myPrice.GatherConData();
                System.Console.WriteLine("Total:" + myPrice.GetTotalPurchase());
            }
            else if (command1 == "2")
            {
                Price myPrice = new Price();
                myPrice.GatherMatineePrice();
                myPrice.GatherConData();
                System.Console.WriteLine("Total:" + myPrice.GetTotalPurchase());
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Invalid option");
            }


            EndofProgram();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private static void ShowMovieMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("  ");
            System.Console.WriteLine("What time? ");
            System.Console.WriteLine("type: 1 - Matinee:Before 5pm.");
            System.Console.WriteLine("type: 2 - Evening:After 5pm. ");
               }

        private static void CollectMovieTime()
        {
            System.Console.WriteLine();
            System.Console.Write(" ");
        }

        private static void EndofProgram()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" Press any key to continue... ");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}
