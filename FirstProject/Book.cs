using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Student 
    {

        public String Name;
       public  String Gender;
       public double GPA;
        public Student(String aName, String aGender,double aGPA)
        {
            Name = aName;
            Gender = aGender;
            GPA = aGPA;
        }
        public bool HasHonors()
        {
            if (GPA > 7.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


      
      

    }

    
}
