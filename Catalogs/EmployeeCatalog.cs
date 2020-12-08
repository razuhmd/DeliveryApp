using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Catalogs
{
    public class EmployeeCatalog
    {
        private Dictionary<int, Employee> employees { get; }
        
        public EmployeeCatalog()
        {
            employees = new Dictionary<int, Employee>();
            
            employees.Add(1, new Employee() { EmployeeId = 1, EmployeeName = "Peter", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Administrator"});
            employees.Add(2, new Employee() { EmployeeId = 2, EmployeeName = "Bojan", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Driver" });
            employees.Add(3, new Employee() { EmployeeId = 3, EmployeeName = "Okan", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Driver" });
            
        }

        public Dictionary<int, Employee> AllEmployees()
        {
            return employees;
        }
        public void AddEmployees(Employee employee)
        {
            employees.Add(employee.EmployeeId, employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee.EmployeeId);
        }
    }
}
