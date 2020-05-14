using System;

namespace Exescise2
{
    class Employee
    {
             protected string firstName;
             protected string lastName;
             protected string address;
             protected long sin;
             protected double salary;
        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }
        public virtual void Salary(double discount)
        {
            
            Console.Write("Your salary is : ");
            Console.WriteLine(salary * discount/100);
        }
        public override string ToString()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(address);
            Console.WriteLine(sin);
            Console.WriteLine(salary);
            return base.ToString();
        }

         
    }
}
