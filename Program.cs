using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company ragnarAndSons = new Company("Ragnar & Sons INC.", new DateTime(0800,04,21), new List<Employee>{});

            // Create three employees
            Employee ragnar = new Employee("Ragnar", "Odinson", "Legendary Viking", new DateTime(0700,04,21));
            Employee ubbe = new Employee("Ubbe", "Ragnarson", "Certified Badass", new DateTime(0700,04,22));
            Employee bjorn = new Employee("Bjorn", "Ironside", "Bear Fighter", new DateTime(0700,04,22));

            // Assign the employees to the company
            ragnarAndSons.Employees.Add(ragnar);
            ragnarAndSons.Employees.Add(ubbe);
            ragnarAndSons.Employees.Add(bjorn);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            ragnarAndSons.ListEmployees();
        }
    }
}
