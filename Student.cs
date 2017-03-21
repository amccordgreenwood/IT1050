namespace Lab3
{
    class Student
    {
        string Name;
        int Grade;
        Instructor Teacher;

        public Student(string name, int grade)  //, Instructor teacher  not sure how to add the 3rd variable
        {
            this.Name = name;
            this.Grade = grade;
            // this.Teacher = teacher;

        }
        public Student()
        {
            Grade = 0;
        }

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public void SetGrade(int x)
        {
            this.Grade = x;
        }

        public void StudentInfo(string student, int grade, Instructor teacher)

        {
            System.Console.WriteLine("Student: " + student + " has a grade of " + grade + " for " + Instructor.GetCourseName());

        }

    }
}
