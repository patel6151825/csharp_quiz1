using System;
using System.Collections.Generic;
using System.Text;

namespace payal_csharp_quiz1
{
    class Employee
    {
        public int id;
        public string name;
        private double salary;

        public Employee()
        {
            //default constructor
        }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void getHighest(List<Employee> listEmployees)
        {
            double highest = 0;
            string empName = "";
            foreach(var emp in listEmployees)
            {
                if (emp.salary>highest)
                {
                    highest = emp.salary;
                    empName = emp.name;
                }
            }
            Console.WriteLine($"Highest Salary is {highest} of employee name {empName}");
        }
        public void getLowest(List<Employee> listEmployees)
        {
            double lowest = listEmployees[0].salary;
            string empName = "";
            foreach (var emp in listEmployees)
            {
                if (emp.salary < lowest)
                {
                    lowest = emp.salary;
                    empName = emp.name;
                }
            }
            Console.WriteLine($"Lowest Salary is {lowest} of employee name {empName}");
            
        }

        public override string ToString()
        {
            Console.WriteLine("Name: "+this.name);
            return base.ToString();
        }
    }
}
