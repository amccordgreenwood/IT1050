namespace StudentInstructor
{
    class Student
    {
        //public string Name;
        //public int Grade;
        private string name;   // lower case "name" is the variable 
        private int grade;
        private string teacher;

        // constructors with no return type 
        public  Student(string Name, int Grade, string Teacher)  
        {
            this.name = Name;        // parameter is to the left of the =  variables
            this.grade = Grade;      // parameter is to the left of the =  variables
            this.teacher = Teacher;  // parameter is to the left of the =  variables
        }

        private void SetName(string newName)  //local variable 
        {
            //
            this.name = newName; 
        }  // that string name goes out of scope

        public string GetName()
        {
            return  name; }
          
             
          public void SetGrade(int theGrade)//local variable 
        {
            this.grade = theGrade;
        }
        public int GetGrade()
        {
            return this.grade;
        }
                public void PrintAllInformation()
        {

        }
    
                      
        }
        
        }
    
      
        
                   
           
        
            
         
        
        
            
    

