namespace StudentInstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor theInstructor1 = new Instructor("John","English");
            //theInstructor1.Name = "John";
            //theInstructor1.CourseName = "English";

            Instructor theInstructor2 = new Instructor("Mike","Math");  //Instructer is the type
            //theInstructor2.Name = "Mike";
            //theInstructor2.CourseName = "Math";

            Student student1 = new Student("Jane",95, "John");
           // student1.Name = "Jane";
            //student1.Grade = 95;


            Student student2 = new Student("Joe",85,"John");
            //student2.Name = "John";
            //student1.Grade = 85;

            Student student3 = new Student("Melissa", 95, "Mike");
            // student1.Name = "Melissa";
            //student1.Grade = 95;

            Student student4 = new Student("Matt", 95, "Mike");
            // student1.Name = "Matt";
            //student1.Grade = 95;

            System.Console.WriteLine("Student's name is:", student1.GetName(), student1.GetGrade()); 
            System.Console.WriteLine("Instructor's name is:", theInstructor1.GetName(), theInstructor1.GetCourseName());
            System.Console.ReadKey();
        }
    }
}
