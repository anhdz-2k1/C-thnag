using ex1;
using System;
using System.Collections.Generic;
using System.Text;

namespace lad2
{
    class TechnicalEmployee: Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }
        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
