using lad2;
using System;
using System.Collections.Generic;
using System.Text;

namespace lad1
{
    class Program
    {
        public static void Main(String[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());

        }
    }
}
