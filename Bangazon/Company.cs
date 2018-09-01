using System;
using System.Collections.Generic;

namespace Bangazon
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        // readonly field
        public readonly List<Employee> Employees = new List<Employee>();
        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee newEmployee)
        {
            this.Employees.Add(newEmployee);
        }
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee exsitingEmployee)
        {
            this.Employees.Remove(exsitingEmployee);
        }
        // List employees
        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime date)
        {
            this.Name = name;
            this.CreatedOn = date;
        }
    }
}
