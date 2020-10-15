using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name;
        
        public string name
        {
            get { return Name;  }
            set { Name = value; }
        }

        private int StudentId;
        
        public int studentId
        {
            get { return StudentId; }
            set { StudentId = value; }
        }

        private int NumberOfCredits;

        public int numberOfCredits
        {
            get { return NumberOfCredits; }
            set { NumberOfCredits = value; }
        }

        private double Gpa;

        public double gpa
        {
            get { return Gpa; }
            set { Gpa = value; }
        }
    }

    
}
