using System;
using System.Collections.Generic;
using System.Text;

namespace lad1
{
    class BusinessEmployee: Employee
    {
        public BusinessEmployee(String name): base(name, 5000)
        {

        }
        public double bonusBudget = 1000;
        public override string employeeStatus()
        {
            return toString() + " with a budgef of " + this.bonusBudget;
        }
    }
}
