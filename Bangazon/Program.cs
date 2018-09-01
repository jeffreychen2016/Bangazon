using System;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            var comdata = new Company("Fake Company", new DateTime(2018,01,05));
            var employee1 = new Employee("Jeffrey", "DIS", new DateTime(2017,9,11));
            var employee2 = new Employee("Ed", "DIS", new DateTime(2017, 11, 11));
            var employee3 = new Employee("Regina", "DIS", new DateTime(2017, 11, 01));

            comdata.AddEmployee(employee1);
            comdata.AddEmployee(employee2);
            comdata.AddEmployee(employee3);

            comdata.ListEmployees();
        }
    }


}
