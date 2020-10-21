using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<double> totalScore = new List<double> { };

        public string GetGradeLevel()
        {
            string freshman = "Freshman";
            string sophomore = "Sophmore";
            string junior = "Junior";
            string senior = "Senior";
            
            if (numberOfCredits <= 29)
            {
                return freshman;
            }
            else if (numberOfCredits >= 30 && numberOfCredits <= 59)
            {
                return sophomore;
            }
            else if (numberOfCredits >= 60 && numberOfCredits <= 89)
            {
                return junior;
            }
            else
            {
                return senior;
            }
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore = grade * courseCredits;
            totalScore.Add(qualityScore);
            numberOfCredits += courseCredits;
            gpa = totalScore.Sum() / numberOfCredits;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    
}
