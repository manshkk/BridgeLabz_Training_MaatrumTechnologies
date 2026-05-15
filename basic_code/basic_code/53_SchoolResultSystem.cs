/*
 * Program: School Result System using OOP Concepts
 * 
 * Concepts Used:
 * 1. Encapsulation (Student Class)
 * 2. Abstraction (Interface + Abstract Class)
 * 3. Inheritance (SchoolResult extends Result)
 * 4. Polymorphism (Method Overriding)
 */

using System;

namespace basic_code
{
    // 1️⃣ Encapsulation
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = "";

        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
    }

    // 2️⃣ Interface (Abstraction)
    internal interface GradeCalculator
    {
        double CalculatePercentage();
        string CalculateGrade(double percentage);
    }

    // 3️⃣ Abstract Class
    internal abstract class Result
    {
        protected Student student;

        public Result(Student student)
        {
            this.student = student;
        }

        public abstract void DisplayResult();
    }

    // 4️⃣ Implementation (Inheritance + Polymorphism)
    internal class SchoolResult : Result, GradeCalculator
    {
        public SchoolResult(Student student) : base(student) { }

        public double CalculatePercentage()
        {
            double total = student.Math + student.Science + student.English;
            return total / 3.0;
        }

        public string CalculateGrade(double percentage)
        {
            if (percentage >= 90) return "A";
            else if (percentage >= 80) return "B";
            else if (percentage >= 70) return "C";
            else if (percentage >= 60) return "D";
            else return "F";
        }

        public override void DisplayResult()
        {
            double percentage = CalculatePercentage();
            string grade = CalculateGrade(percentage);

            Console.WriteLine("\n===== RESULT =====");
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Percentage: " + percentage.ToString("F2"));
            Console.WriteLine("Grade: " + grade);
        }
    }
}
