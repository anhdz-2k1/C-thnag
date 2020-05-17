using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public abstract class Employee: Person
    {
        private string department;
        private double salary;
        private DateTimeKind Datehired;
        
        public Employee(string x, double y, DateTimeKind z, String name, string phone, string email) : base(name, phone, email)
        {
            this.department = x;
            this.salary = y;
            this.Datehired = z;
        }
        public string PDepartment
        {
            get { return department; }
            set { department = value; }
        }
        public double PSalary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTimeKind PDatehired
        {
            get { return Datehired; }
            set { Datehired = value; }
        }

        public override string ToString()
        {
            return "Employee has: department is " + department + ", salary is " + salary + ", datehired is " + Datehired + "name is " + PName + ", phone is " + PPhone + ", email is " + PEmail;
        }
        public abstract double CalculateBonus();
        public abstract string CalculateVacation();


    }
}
