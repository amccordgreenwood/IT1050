namespace Lab3
{
    class Instructor
    {

        string Name;
        string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);

        }

            public string GetCourseName()
        {
            return this.Name + " in  " + this.CourseName + " class. ";
        }

       }
    }


