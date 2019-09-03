using System;

namespace EmployeeTestLibrary {
    public class Employee {

        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }

        public virtual string Print() { //this one gets override from other print method. Other needs override
            return $"{Name} - {Job} | Salary: {Salary.ToString("C")}";
        }

        public Employee(string name, string job, decimal salary) {
            Name = name;
            Job = job;
            Salary = salary;
        }
    }
}
