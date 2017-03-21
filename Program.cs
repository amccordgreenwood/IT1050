namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");

            //System.Console.WriteLine("Pausing 5 seconds");
            //System.Threading.Thread.Sleep(5000);

            Instructor Mike = new Instructor("Mike", "Math");


            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt",Mike);

         
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
