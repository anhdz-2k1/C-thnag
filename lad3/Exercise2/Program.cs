using System;
using System.Collections.Generic;
using System.Text;

namespace Exescise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstname,lastname,address;
            long sin;
            double salary;
            Console.ReadLine();
            Console.Write("Enter first name: " );
            firstname = Console.ReadLine();
            Console.Write("Enter last name: " );
            lastname = Console.ReadLine();
            Console.Write("Enter address: " );
            address = Console.ReadLine();
            Console.Write("Enter sin: ");
            sin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter salary: ");
            salary = Convert.ToSingle(Console.ReadLine());            
            Employee emp = new Employee(firstname, lastname, address, sin, salary);
            double discount;
            Console.Write("enter discount: ");
            discount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("----------");
            emp.ToString();
            emp.Salary(discount);
        }
    }
}
