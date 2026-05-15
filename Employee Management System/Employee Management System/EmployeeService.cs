using System;

namespace Employee_Management_System
{
    public class EmployeeService : IEmployeeService
    {
        private Employee[] employees = new Employee[10];
        private int count = 0;

        public void AddEmployee(Employee employee)
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == employee.Id)
                {
                    Console.WriteLine("Duplicate ID not allowed");
                    return;
                }
            }

            employees[count++] = employee;
            Console.WriteLine("Employee added");
        }

        public void DeleteEmployee(int id)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Not found");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                employees[i] = employees[i + 1];
            }

            employees[count - 1] = null;
            count--;

            Console.WriteLine("Deleted");
        }

        public void RemoveEmployee(int id)
        {
            DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == employee.Id)
                {
                    employees[i].Name = employee.Name;
                    employees[i].Email = employee.Email;
                    employees[i].Salary = employee.Salary;
                    employees[i].Department = employee.Department;

                    Console.WriteLine("Updated");
                    return;
                }
            }

            Console.WriteLine("Not found");
        }
        public void DisplayEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees found");
                return;
            }

            Console.WriteLine("\nEmployee List:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"ID: {employees[i].Id}, Name: {employees[i].Name}, Email: {employees[i].Email}, Salary: {employees[i].Salary}, Dept: {employees[i].Department}");
            }
        }
    }
}