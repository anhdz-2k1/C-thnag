using ex1;
using System;
using System.Collections.Generic;
using System.Text;

namespace lad2
{
    class BusinessEmployee: Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(String name) : base(name, 5000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " with a budget of" + this.bonusBudget;
        }
    }
}
