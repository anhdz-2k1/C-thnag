using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Staff : Employee
    {
        public Staff(string x, double y, DateTimeKind z, String name, string phone, string email) : base(x,y,z,name, phone, email)
        {
            
        }
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * PSalary;
        }

        public override string CalculateVacation()
        {
            if (PDatehired > 2 / 2 / 2010)
            {
                return "4 week";
            }
            else
            {
                return "3 weeks";
            }
        }
    }
}
