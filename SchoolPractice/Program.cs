using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student monique = new Student();

            monique.name = "Monique";
            monique.studentId = 1;
            monique.numberOfCredits = 1;
            monique.gpa = 4.0;

            Console.WriteLine($"Name: {monique.name}\n" +
                $"ID: {monique.studentId}\n" +
                $"Credits: {monique.numberOfCredits}\n" +
                $"GPA: {monique.gpa}");

        }
    }
}
