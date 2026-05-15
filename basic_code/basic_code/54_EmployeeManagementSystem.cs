/*
 * Program: Employee Management System using OOP
 * 
 * Concepts:
 * 1. Encapsulation → Salary fields are private
 * 2. Abstraction → Employee is abstract class
 * 3. Inheritance → Derived employee types
 * 4. Polymorphism → Method overriding
 */

using System;

namespace basic_code
{
    // 🔹 Abstract Base Class
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        protected double salary; // encapsulated

        // Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Abstract method
        public abstract void CalculateSalary();

        // Display method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("\n----- Employee Details -----");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + salary);
        }
    }

    // 🔹 Full-Time Employee
    internal class FullTimeEmployee : Employee
    {
        private double monthlySalary;

        public FullTimeEmployee(int id, string name, double monthlySalary)
            : base(id, name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override void CalculateSalary()
        {
            salary = monthlySalary;
        }
    }

    // 🔹 Part-Time Employee
    internal class PartTimeEmployee : Employee
    {
        private int hoursWorked;
        private double ratePerHour;

        public PartTimeEmployee(int id, string name, int hours, double rate)
            : base(id, name)
        {
            hoursWorked = hours;
            ratePerHour = rate;
        }

        public override void CalculateSalary()
        {
            salary = hoursWorked * ratePerHour;
        }
    }

    // 🔹 Contract Employee
    internal class ContractEmployee : Employee
    {
        private double projectAmount;

        public ContractEmployee(int id, string name, double amount)
            : base(id, name)
        {
            projectAmount = amount;
        }

        public override void CalculateSalary()
        {
            salary = projectAmount;
        }
    }
}
