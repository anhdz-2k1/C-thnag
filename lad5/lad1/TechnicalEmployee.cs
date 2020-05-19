using System;
using System.Collections.Generic;
using System.Text;

namespace lad1
{
    class TechnicalEmployee: Employee
    {
        public TechnicalEmployee(String name): base(name, 75000)
        {

        }
        public int successfulCheckIns = 5;
        public override string employeeStatus()
        {
            return this.toString() + "has " + this.successfulCheckIns + "successfull check ins";

        }

    }
}
