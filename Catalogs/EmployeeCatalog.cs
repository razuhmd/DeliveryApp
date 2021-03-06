﻿using DeliveryApp.Models;
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
            
            employees.Add(KeyGenerator(), new Employee() { EmployeeId = IdGenerator(), EmployeeName = "Peter", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Administrator"});
            employees.Add(KeyGenerator(), new Employee() { EmployeeId = IdGenerator(), EmployeeName = "Bojan", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Driver" });
            employees.Add(KeyGenerator(), new Employee() { EmployeeId = IdGenerator(), EmployeeName = "Okan", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Driver" });
            
        }

        public int IdGenerator()
        {
            List<int> idList = new List<int>();
            int id = 1;
            foreach (var item in employees.Values)
            {
                idList.Add(item.EmployeeId);
            }
            if (idList.Count != 0)
            {
                id = idList.Max() + 1;
            }
            return id;
        }

        public int KeyGenerator()
        {
            List<int> keyList = new List<int>();
            int key = 1;
            foreach (var item in employees.Keys)
            {
                keyList.Add(item);
            }
            if (keyList.Count != 0)
            {
                key = keyList.Max() + 1;
            }
            return key;
        }

        public Dictionary<int, Employee> AllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach(var empployee in employees.Values)
            {
                if(empployee.EmployeeId == id)
                {
                    return empployee;
                }
            }
            return null;
        }

        public void AddEmployees(Employee employee)
        {
            employee.EmployeeId = IdGenerator();
            employees.Add(KeyGenerator(), employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee.EmployeeId);
        }

        public bool UpdateEmployee(Employee editEmployee)
        {
            foreach (var employeeItem in employees.Values)
            {
                if (employeeItem.EmployeeId == editEmployee.EmployeeId)
                {
                    employeeItem.EmployeeId = editEmployee.EmployeeId;
                    employeeItem.EmployeeName = editEmployee.EmployeeName;
                    employeeItem.EmployeeEmail = editEmployee.EmployeeEmail;
                    employeeItem.EmployeeAddress = editEmployee.EmployeeAddress;
                    employeeItem.EmployeePhoneNumber = editEmployee.EmployeePhoneNumber;
                    employeeItem.EmployeeType = editEmployee.EmployeeType;

                    return true;
                }
            }
            return false;
        }

        public Dictionary<int, Employee> Search(string searchFor)
        {
            Dictionary<int, Employee> searchedEmployee = new Dictionary<int, Employee>();

            foreach (var employee in employees.Values)
            {
                if (employee.EmployeeName.StartsWith(searchFor) || employee.EmployeeType.StartsWith(searchFor) || employee.EmployeeEmail.StartsWith(searchFor) || employee.EmployeePhoneNumber.StartsWith(searchFor))
                {  
                    searchedEmployee.Add(employee.EmployeeId, employee);
                }
            }

            return searchedEmployee;
        }
    }
}
