using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseName { get; set; }
        public double CourseUnit { get; set; }
        private List<Student> StudentList = new List<Student>();
        public List<Student> studentList
        {
            get { return StudentList; }
            set { StudentList = value; }
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
