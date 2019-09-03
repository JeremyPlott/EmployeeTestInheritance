using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTestLibrary {

    public class Manager : Employee {

        public int TeamSize { get; set; }

        public override string Print() { //this print overrides the print in employee. other one needs to be virtual
            return base.Print() + $"| Team size: {TeamSize}";
        }

        public Manager(int teamsize, string name, string job, decimal salary) : base(name, job, salary) {
            TeamSize = teamsize;
        }
    }
}
