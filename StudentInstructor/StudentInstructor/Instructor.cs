namespace StudentInstructor
{
    class Instructor
    {

        //public string Name;
        //public string CourseName;

            //variables
        private string name;
        private string courseName;
        private bool GetNamecourseName;
        
        // constructor
        public Instructor(string theirName, string theCourseName)

        {
            SetName(theirName);

        }

        //functions
        private void SetName(string Name)
        {
            this.name = Name;
        }

        public string GetName()
        {
            return name;

        }
            
        public void SetcourseName(string theCourseName)//local variable 
        {
            this.courseName = theCourseName;
        }
        public string GetCourseName()
        {
            return this.courseName;
        }

          public void PrintNameandCourseName()

        { 
            System.Console.WriteLine(GetNamecourseName);
        }
            }
        }

    

      






