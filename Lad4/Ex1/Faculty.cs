using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Faculty : Employee
    {
        public Faculty(string x, double y, DateTimeKind z, String name, string phone, string email) : base(x, y, z, name, phone, email)
        {

        }
        public override double CalculateBonus()
        {
            return 1000 + 0.06 * PSalary;
        }

        public override string CalculateVacation()
        {           
            if (PDatehired > 2 / 2 / 2010)
            {
                return "5 week";
            }
            else 
            { 
                return "4 weeks"; 
            }
        }
    }
}
