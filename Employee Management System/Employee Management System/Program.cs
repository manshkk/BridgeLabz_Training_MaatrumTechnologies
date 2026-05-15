using System;

namespace Employee_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService();

            service.AddEmployee(new Employee { Id = 1, Name = "Manish", Email = "m@gmail.com", Salary = 50000, Department = "IT" });
            service.AddEmployee(new Employee { Id = 2, Name = "Rahul", Email = "r@gmail.com", Salary = 40000, Department = "HR" });

            
            service.AddEmployee(new Employee { Id = 1, Name = "Duplicate", Email = "d@gmail.com", Salary = 30000, Department = "Sales" });

            service.DisplayEmployees();

            
            service.UpdateEmployee(new Employee { Id = 1, Name = "Manish Updated", Email = "new@gmail.com", Salary = 60000, Department = "IT" });

            
            service.DeleteEmployee(2);

            service.DisplayEmployees();
        }
    }
}