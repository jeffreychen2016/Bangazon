using System;

namespace Bangazon
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string title, DateTime startDate)
        {
            this.Name = name;
            this.Title = title;
            this.StartDate = startDate;
        }
    }
}
