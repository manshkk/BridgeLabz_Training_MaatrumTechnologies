using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        void RemoveEmployee(int id);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
